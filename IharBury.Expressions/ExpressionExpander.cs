using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace IharBury.Expressions
{
    internal sealed class ExpressionExpander : ExpressionVisitor
    {
        private static readonly MethodInfo MethodInfoCreateDelegateMethod =
            ReflectionExpressions.GetMethodInfo<MethodInfo>(methodInfo =>
                methodInfo.CreateDelegate(default(Type), default(object)));

        private static readonly MethodInfo DelegateCreateDelegateMethod =
            ReflectionExpressions.GetMethodInfo(() =>
                Delegate.CreateDelegate(default(Type), default(object), default(MethodInfo)));

        private ExpressionExpander() { }

        [Pure]
        public static Expression ExpandExpression(Expression expression)
        {
            Contract.Requires<ArgumentNullException>(expression != null);
            Contract.Ensures(Contract.Result<Expression>() != null);

            return new ExpressionExpander().Visit(expression);
        }

        [Pure]
        private static LambdaExpression TryGetLambdaExpressionFromExpression(Expression expression)
        {
            Contract.Requires<ArgumentNullException>(expression != null);

            if (expression.NodeType == ExpressionType.Quote)
                return (LambdaExpression)((UnaryExpression)expression).Operand;

            if (ExpressionParameterPresenceDetector.DoesExpressionHaveParameters(expression))
                return null;

            // Testing showed that evaluation via compilation works faster and the result is GCed.
            return (LambdaExpression)Expression.Lambda(expression).Compile().DynamicInvoke();
        }

        [Pure]
        private static bool IsEvaluateMethod(MethodInfo method)
        {
            Contract.Requires<ArgumentNullException>(method != null);

            return (method.DeclaringType == typeof(Extensions)) && (method.Name == nameof(Extensions.Evaluate));
        }

        [Pure]
        private static bool IsCompileMethod(MethodInfo method)
        {
            Contract.Requires<ArgumentNullException>(method != null);

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
                (baseResult.Method.DeclaringType.BaseType == typeof(MulticastDelegate)) &&
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
            IReadOnlyList<Expression> arguments,
            out Expression result)
        {
            Contract.Requires<ArgumentNullException>(expressionExpression != null);
            Contract.Requires<ArgumentNullException>(arguments != null);
            Contract.Requires((TryGetLambdaExpressionFromExpression(expressionExpression) == null) ||
                (TryGetLambdaExpressionFromExpression(expressionExpression).Parameters.Count == arguments.Count));
            Contract.Ensures(!Contract.Result<bool>() || (Contract.ValueAtReturn(out result) != null));

            var lambdaExpression = TryGetLambdaExpressionFromExpression(expressionExpression);
            if (lambdaExpression != null)
            {
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
