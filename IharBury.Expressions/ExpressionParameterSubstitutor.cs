using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq.Expressions;

namespace IharBury.Expressions
{
    internal sealed class ExpressionParameterSubstitutor : ExpressionVisitor
    {
        private readonly Dictionary<ParameterExpression, Expression> parameterSubstitutions;

        private ExpressionParameterSubstitutor(IDictionary<ParameterExpression, Expression> parameterSubstitutions)
        {
            Contract.Requires<ArgumentNullException>(parameterSubstitutions != null);

            this.parameterSubstitutions = new Dictionary<ParameterExpression, Expression>(parameterSubstitutions);
        }

        [Pure]
        public static Expression SubstituteParameters(
            Expression expression,
            IDictionary<ParameterExpression, Expression> parameterSubstitutions)
        {
            Contract.Requires<ArgumentNullException>(parameterSubstitutions != null);

            return new ExpressionParameterSubstitutor(parameterSubstitutions).Visit(expression);
        }

        [Pure]
        public static Expression SubstituteParameter(
            Expression expression,
            ParameterExpression oldParameter,
            Expression newParameter)
        {
            Contract.Requires<ArgumentNullException>(oldParameter != null);

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

            return node.Update(Visit(node.Body), newParameters);
        }

        [ContractInvariantMethod]
        private void Invariants()
        {
            Contract.Invariant(parameterSubstitutions != null);
        }
    }
}
