using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace IharBury.Expressions
{
    internal sealed class ExpressionParameterSubstitutor : ExpressionVisitor
    {
        private readonly Dictionary<ParameterExpression, Expression> parameterSubstitutions;

        private ExpressionParameterSubstitutor(IDictionary<ParameterExpression, Expression> parameterSubstitutions)
        {
            if (parameterSubstitutions == null)
                throw new ArgumentNullException(nameof(parameterSubstitutions));

            this.parameterSubstitutions = new Dictionary<ParameterExpression, Expression>(parameterSubstitutions);
        }

        public static Expression SubstituteParameters(
            Expression expression,
            IDictionary<ParameterExpression, Expression> parameterSubstitutions)
        {
            if (parameterSubstitutions == null)
                throw new ArgumentNullException(nameof(parameterSubstitutions));

            return new ExpressionParameterSubstitutor(parameterSubstitutions).Visit(expression);
        }

        public static Expression SubstituteParameter(
            Expression expression,
            ParameterExpression oldParameter,
            Expression newParameter)
        {
            if (oldParameter == null)
                throw new ArgumentNullException(nameof(oldParameter));

            return SubstituteParameters(
                expression,
                new Dictionary<ParameterExpression, Expression>
                {
                    {
                        oldParameter,
                        newParameter
                    }
                });
        }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            Expression substitution;
            return parameterSubstitutions.TryGetValue(node, out substitution) ?
                SubstituteParameters(substitution, new Dictionary<ParameterExpression, Expression>()) :
                base.VisitParameter(node);
        }

        protected override Expression VisitLambda<T>(Expression<T> node)
        {
            var newParameters = new List<ParameterExpression>(node.Parameters.Count);

            foreach (var oldParameter in node.Parameters)
            {
                var newParameter = Expression.Parameter(oldParameter.Type, oldParameter.Name);
                newParameters.Add(newParameter);
                parameterSubstitutions.Add(oldParameter, newParameter);
            }

            // There is no matching Update method in .NET Core yet.
            return Expression.Lambda<T>(Visit(node.Body), node.Name, node.TailCall, newParameters);
        }
    }
}
