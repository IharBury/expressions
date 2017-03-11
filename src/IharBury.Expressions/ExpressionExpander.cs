using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace IharBury.Expressions
{
    internal sealed class ExpressionExpander : ExpressionVisitor
    {
        private static readonly MethodInfo MethodInfoCreateDelegateMethod = 
            FindMethod(typeof(MethodInfo), "CreateDelegate", typeof(Type), typeof(object));
        private static readonly MethodInfo DelegateCreateDelegateMethod = 
            FindMethod(typeof(Delegate), "CreateDelegate", typeof(Type), typeof(object), typeof(MethodInfo));

        private static MethodInfo FindMethod(Type type, string name, params Type[] parameterTypes)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException($"string.{nameof(string.IsNullOrEmpty)}({nameof(name)}name)", nameof(name));
            if (parameterTypes == null)
                throw new ArgumentNullException(nameof(parameterTypes));

            return type
                .GetTypeInfo()
                .GetDeclaredMethods(name)
                .SingleOrDefault(method =>
                    method.GetParameters().Select(parameter => parameter.ParameterType).SequenceEqual(parameterTypes));
        }

        private ExpressionExpander() { }

        public static Expression ExpandExpression(Expression expression)
        {
            if (expression == null)
                throw new ArgumentNullException(nameof(expression));

            return new ExpressionExpander().Visit(expression);
        }

        private static LambdaExpression TryGetLambdaExpressionFromExpression(Expression expression)
        {
            if (expression == null)
                throw new ArgumentNullException(nameof(expression));

            if (expression.NodeType == ExpressionType.Quote)
                return (LambdaExpression)((UnaryExpression)expression).Operand;

            if (ExpressionParameterPresenceDetector.DoesExpressionHaveParameters(expression))
                return null;

            // Testing showed that evaluation via compilation works faster and the result is GCed.
            return (LambdaExpression)Expression.Lambda(expression).Compile().DynamicInvoke();
        }

        private static bool IsEvaluateMethod(MethodInfo method)
        {
            if (method == null)
                throw new ArgumentNullException(nameof(method));

            return (method.DeclaringType == typeof(Extensions)) && (method.Name == nameof(Extensions.Evaluate));
        }

        private static bool IsCompileMethod(MethodInfo method)
        {
            if (method == null)
                throw new ArgumentNullException(nameof(method));

            return (method.DeclaringType != null) &&
                method.DeclaringType.IsConstructedGenericType &&
                (method.DeclaringType.GetGenericTypeDefinition() == typeof(Expression<>)) &&
                (method.Name == nameof(Expression<Func<object>>.Compile));
        }

        protected override Expression VisitInvocation(InvocationExpression node)
        {
            var baseResult = (InvocationExpression)base.VisitInvocation(node);

            if (baseResult.Expression.NodeType == ExpressionType.Call)
            {
                var methodCallExpression = (MethodCallExpression)baseResult.Expression;

                if (IsCompileMethod(methodCallExpression.Method))
                {
                    Expression result;
                    if (TrySubstituteExpression(methodCallExpression.Object, baseResult.Arguments, out result))
                        return result;
                }
            }

            return baseResult;
        }

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            var baseResult = (MethodCallExpression)base.VisitMethodCall(node);

            if (IsEvaluateMethod(baseResult.Method))
            {
                if (baseResult.Arguments[0] == null)
                    throw new InvalidOperationException("Expression being evaluated should not be null.");

                Expression result;
                if (TrySubstituteExpression(baseResult.Arguments[0], baseResult.Arguments.Skip(1).ToList(), out result))
                    return result;
            }

            if ((baseResult.Method.DeclaringType != null) &&
                (baseResult.Method.DeclaringType.GetTypeInfo().BaseType == typeof(MulticastDelegate)) &&
                (baseResult.Method.Name == nameof(Action.Invoke)) &&
                (baseResult.Object != null) &&
                (baseResult.Object.NodeType == ExpressionType.Call))
            {
                var methodCallExpression = (MethodCallExpression)baseResult.Object;

                if (IsCompileMethod(methodCallExpression.Method))
                {
                    Expression result;
                    if (TrySubstituteExpression(methodCallExpression.Object, baseResult.Arguments, out result))
                        return result;
                }
            }

            if ((baseResult.Method == MethodInfoCreateDelegateMethod) && (baseResult.Object.NodeType == ExpressionType.Constant))
            {
                var constantExpression = (ConstantExpression)baseResult.Object;
                if (IsEvaluateMethod((MethodInfo)constantExpression.Value))
                {
                    if (baseResult.Arguments[1] == null)
                        throw new InvalidOperationException("Expression being evaluated should not be null.");

                    var innerExpression = TryGetLambdaExpressionFromExpression(baseResult.Arguments[1]);
                    if (innerExpression != null)
                        return Visit(ExpressionParameterSubstitutor.SubstituteParameters(
                            innerExpression,
                            new Dictionary<ParameterExpression, Expression>()));
                }
            }

            if ((baseResult.Method == DelegateCreateDelegateMethod) &&
                (baseResult.Arguments[2].NodeType == ExpressionType.Constant))
            {
                var constantExpression = (ConstantExpression)baseResult.Arguments[2];
                if (IsEvaluateMethod((MethodInfo)constantExpression.Value))
                {
                    if (baseResult.Arguments[1] == null)
                        throw new InvalidOperationException("Expression being evaluated should not be null.");

                    var innerExpression = TryGetLambdaExpressionFromExpression(baseResult.Arguments[1]);
                    if (innerExpression != null)
                        return Visit(ExpressionParameterSubstitutor.SubstituteParameters(
                            innerExpression,
                            new Dictionary<ParameterExpression, Expression>()));
                }
            }

            return baseResult;
        }

        protected override Expression VisitUnary(UnaryExpression node)
        {
            var baseResult = base.VisitUnary(node);
            if (baseResult.NodeType == ExpressionType.Convert)
            {
                var baseResultUnary = (UnaryExpression)baseResult;
                if ((baseResultUnary.Type == baseResultUnary.Operand.Type) &&
                        (baseResultUnary.Method == null) &&
                        !baseResultUnary.IsLifted &&
                        !baseResultUnary.IsLiftedToNull)
                    return baseResultUnary.Operand;
            }

            return baseResult;
        }

        private bool TrySubstituteExpression(
            Expression expressionExpression,
            IList<Expression> arguments,
            out Expression result)
        {
            if (expressionExpression == null)
                throw new ArgumentNullException(nameof(expressionExpression));
            if (arguments == null)
                throw new ArgumentNullException(nameof(arguments));

            var lambdaExpression = TryGetLambdaExpressionFromExpression(expressionExpression);
            if (lambdaExpression != null)
            {
                if (lambdaExpression.Parameters.Count != arguments.Count)
                    throw new InvalidOperationException("Parameter count mismatch.");

                var visitedLambdaExpression = (LambdaExpression)Visit(lambdaExpression);

                var parameterSubstitutions = new Dictionary<ParameterExpression, Expression>();
                for (var parameterIndex = 0;
                    parameterIndex < visitedLambdaExpression.Parameters.Count;
                    parameterIndex++)
                {
                    var originalParameter = visitedLambdaExpression.Parameters[parameterIndex];
                    var replacedParameter = arguments[parameterIndex];
                    parameterSubstitutions.Add(originalParameter, replacedParameter);
                }

                result = Visit(ExpressionParameterSubstitutor.SubstituteParameters(
                    visitedLambdaExpression.Body,
                    parameterSubstitutions));
                return true;
            }

            result = default(Expression);
            return false;
        }
    }
}
