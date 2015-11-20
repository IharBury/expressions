﻿using System.Collections.Generic;
using System.Linq.Expressions;

namespace IharBury.Expressions
{
    internal sealed class ExpressionParameterPresenceDetector : ExpressionVisitor
    {
        private readonly List<ParameterExpression> allowedParameters = new List<ParameterExpression>();
        private bool doesExpressionHaveParameters;

        private ExpressionParameterPresenceDetector() { }

        public static bool DoesExpressionHaveParameters(Expression expression)
        {
            var detector = new ExpressionParameterPresenceDetector();
            detector.Visit(expression);
            return detector.doesExpressionHaveParameters;
        }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            if (!allowedParameters.Contains(node))
                doesExpressionHaveParameters = true;

            return base.VisitParameter(node);
        }

#if NET35 || NET35_CLIENT || NET37_CF
        protected override Expression VisitLambda(LambdaExpression node)
#else
        protected override Expression VisitLambda<T>(Expression<T> node)
#endif
        {
            allowedParameters.AddRange(node.Parameters);
            var result = base.VisitLambda(node);
            foreach (var parameter in node.Parameters)
                allowedParameters.Remove(parameter);
            return result;
        }
    }
}
