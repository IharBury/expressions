﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
#if NETFX_CORE || WINDOWS_PHONE 
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
#else
using Microsoft.VisualStudio.TestTools.UnitTesting;
#endif

namespace Mindbox.Expressions.Tests
{
	[TestClass]
	public class ExpressionEvaluatorTests
	{
		[TestMethod]
		public void EvaluateLambdaAsFunc()
		{
			var values = new[]
			{
				1,
				2,
				3
			};
			Expression<Func<int>> expression = () => values.Where(value => value != 2).Sum();
			var result = ExpressionEvaluator.Instance.Evaluate(expression.Body);
			Assert.AreEqual(4, result);
		}
	}
}
