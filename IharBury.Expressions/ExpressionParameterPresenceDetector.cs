using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace IharBury.Expressions
{
	internal sealed class ExpressionParameterPresenceDetector : ExpressionVisitor
	{
		public static bool DoesExpressionHaveParameters(Expression expression)
		{
			var detector = new ExpressionParameterPresenceDetector();
			detector.Visit(expression);
			return detector.doesExpressionHaveParameters;
		}


		private ExpressionParameterPresenceDetector() { }


		private bool doesExpressionHaveParameters;
		private readonly List<ParameterExpression> allowedParameters = new List<ParameterExpression>();


		protected override Expression VisitParameter(ParameterExpression node)
		{
			if (node == null)
				throw new ArgumentNullException(nameof(node));

			if (!allowedParameters.Contains(node))
				doesExpressionHaveParameters = true;

			return base.VisitParameter(node);
		}

		protected override Expression VisitLambda<T>(Expression<T> node)
		{
			if (node == null)
				throw new ArgumentNullException(nameof(node));

			allowedParameters.AddRange(node.Parameters);
			var result = base.VisitLambda(node);
			foreach (var parameter in node.Parameters)
				allowedParameters.Remove(parameter);
			return result;
		}
	}
}
