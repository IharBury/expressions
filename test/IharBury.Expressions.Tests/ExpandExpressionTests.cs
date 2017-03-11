using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Xunit;

namespace IharBury.Expressions.Tests
{
    public class ExpandExpressionTests
    {
        [Fact]
        public void ExpandExpressionsSimpleTest()
        {
            Expression<Func<int, int>> f1 = x => x + 2;
            var result = f1.ExpandExpressions();

            NoDuplicateParameterAssertion.AssertNoDuplicateParameters(result);
            Assert.Equal(3, result.Compile()(1));
            NoEvaluationsAssertion.AssertNoEvaluations(result);
        }

        [Fact]
        public void ExpandExpressionsExpand1Test()
        {
            Expression<Func<int, int>> f1 = x => x + 2;
            Expression<Func<int, int>> f2 = x => f1.Compile()(x) * 3;
            var result = f2.ExpandExpressions();

            NoDuplicateParameterAssertion.AssertNoDuplicateParameters(result);
            Assert.Equal(9, result.Compile()(1));
            NoEvaluationsAssertion.AssertNoEvaluations(result);
        }

        [Fact]
        public void ExpandExpressionsExpand1QuoteTest()
        {
            Expression<Func<int, int>> f1 = y => y + 2;

            var x = Expression.Parameter(typeof(int), "x");
            Expression<Func<int, int>> f2 = Expression.Lambda<Func<int, int>>(
                Expression.Multiply(
                    Expression.Call(
                        ReflectionExpressions.GetMethodInfo<Expression<Func<int, int>>>(expression =>
                            expression.Evaluate(default(int))),
                        Expression.Quote(f1),
                        x),
                    Expression.Constant(3)),
                new[]
                {
                    x
                });
            var result = f2.ExpandExpressions();

            NoDuplicateParameterAssertion.AssertNoDuplicateParameters(result);
            Assert.Equal(9, result.Compile()(1));
            NoEvaluationsAssertion.AssertNoEvaluations(result);
        }

        [Fact]
        public void ExpandExpressionsExpand1MethodCallTest()
        {
            Expression<Func<int, int>> f2 = x => Getter().Evaluate(x) * 3;
            var result = f2.ExpandExpressions();

            NoDuplicateParameterAssertion.AssertNoDuplicateParameters(result);
            Assert.Equal(6, result.Evaluate(1));
            NoEvaluationsAssertion.AssertNoEvaluations(result);
        }

        [Fact]
        public void ExpandExpressionsExpand1QuoteParameterizedTest()
        {
            Expression<Func<int, Expression<Func<int, int>>>> f1 = x => y => x * 2 + y;
            Expression<Func<int, int>> f2 = z => f1.Evaluate(z).Evaluate(z * 3) + 1;
            var result = f2.ExpandExpressions();

            NoDuplicateParameterAssertion.AssertNoDuplicateParameters(result);
            Assert.Equal(6, result.Compile()(1));
            NoEvaluationsAssertion.AssertNoEvaluations(result);
        }

        [Fact]
        public void ExpandExpressionsExpand1InvokeTest()
        {
            Expression<Func<int, int>> f1 = x => x + 2;
            Expression<Func<int, int>> f2 = x => f1.Compile().Invoke(x) * 3;
            var result = f2.ExpandExpressions();

            NoDuplicateParameterAssertion.AssertNoDuplicateParameters(result);
            Assert.Equal(9, result.Compile()(1));
            NoEvaluationsAssertion.AssertNoEvaluations(result);
        }

        [Fact]
        public void ExpandExpressionsExpand1EvaluateTest()
        {
            Expression<Func<int, int>> f1 = x => x + 2;
            Expression<Func<int, int>> f2 = x => f1.Evaluate(x) * 3;
            var result = f2.ExpandExpressions();

            NoDuplicateParameterAssertion.AssertNoDuplicateParameters(result);
            Assert.Equal(9, result.Evaluate(1));
            NoEvaluationsAssertion.AssertNoEvaluations(result);
        }

        [Fact]
        public void ExpandExpressionsExpand1EvaluateMethodGroupTest()
        {
            Expression<Func<int, bool>> f1 = x => x == 2;
            Expression<Func<IEnumerable<int>, IEnumerable<int>>> f2 = x => x.Where(f1.Evaluate);
            var result = f2.ExpandExpressions();

            NoDuplicateParameterAssertion.AssertNoDuplicateParameters(result);
            Assert.Equal(3, result.Evaluate(new[] { 1, 2, 2, 2, 3 }).Count());
            NoEvaluationsAssertion.AssertNoEvaluations(result);
            NoConvertAssertion.AssertNoConverts(result);
        }

        [Fact]
        public void ExpandExpressionsExpand2EvaluateMethodGroupTest()
        {
            Expression<Func<int, bool>> f1 = x => x == 2;
            Expression<Func<IEnumerable<int>, IEnumerable<int>>> f2 = x => x.Where(f1.Evaluate).Concat(x.Where(f1.Evaluate));
            var result = f2.ExpandExpressions();

            NoDuplicateParameterAssertion.AssertNoDuplicateParameters(result);
            Assert.Equal(6, result.Evaluate(new[] { 1, 2, 2, 2, 3 }).Count());
            NoEvaluationsAssertion.AssertNoEvaluations(result);
            NoConvertAssertion.AssertNoConverts(result);
        }

        [Fact]
        public void ExpandExpressionsExpandComplexTest()
        {
            Expression<Func<int, int>> f1 = x => x + 2;
            Expression<Func<int, int>> f2 = y => f1.Compile()(y + 4) * 3;
            var result = f2.ExpandExpressions();

            NoDuplicateParameterAssertion.AssertNoDuplicateParameters(result);
            Assert.Equal(21, result.Compile()(1));
            NoEvaluationsAssertion.AssertNoEvaluations(result);
        }

        [Fact]
        public void ExpandExpressionsExpandComplexEvaluateTest()
        {
            Expression<Func<int, int>> f1 = x => x + 2;
            Expression<Func<int, int>> f2 = y => f1.Evaluate(y + 4) * 3;
            var result = f2.ExpandExpressions();

            NoDuplicateParameterAssertion.AssertNoDuplicateParameters(result);
            Assert.Equal(21, result.Evaluate(1));
            NoEvaluationsAssertion.AssertNoEvaluations(result);
        }

        [Fact]
        public void ExpandExpressionsExpandNestedTest()
        {
            Expression<Func<int, int>> f1 = x => x + 2;
            Expression<Func<int, int>> f2 = y => f1.Compile()(f1.Compile()(y) + f1.Compile()(4)) * 3;
            var result = f2.ExpandExpressions();

            NoDuplicateParameterAssertion.AssertNoDuplicateParameters(result);
            Assert.Equal(33, result.Compile()(1));
            NoEvaluationsAssertion.AssertNoEvaluations(result);
        }

        [Fact]
        public void ExpandExpressionsExpandNestedEvaluateTest()
        {
            Expression<Func<int, int>> f1 = x => x + 2;
            Expression<Func<int, int>> f2 = y => f1.Evaluate(f1.Evaluate(y) + f1.Evaluate(4)) * 3;
            var result = f2.ExpandExpressions();

            NoDuplicateParameterAssertion.AssertNoDuplicateParameters(result);
            Assert.Equal(33, result.Evaluate(1));
            NoEvaluationsAssertion.AssertNoEvaluations(result);
        }

        [Fact]
        public void ExpandExpressionsVeryComplexTest()
        {
            Expression<Func<int, Expression<Func<int, int>>>> f1 = x => (y => y + x);
            Expression<Func<int, int>> f2 =
                z => f1.Compile()(f1.Compile()(1).Compile()(z)).Compile()(f1.Compile()(5).Compile()(z));

            Assert.Equal(8, f2.Compile()(1));

            var result = f2.ExpandExpressions();

            NoDuplicateParameterAssertion.AssertNoDuplicateParameters(result);
            Assert.Equal(8, result.Compile()(1));
            NoEvaluationsAssertion.AssertNoEvaluations(result);
        }

        [Fact]
        public void ExpandExpressionsVeryComplexEvaluateTest()
        {
            Expression<Func<int, Expression<Func<int, int>>>> f1 = x => (y => y + x);
            Expression<Func<int, int>> f2 =
                z => f1.Evaluate(f1.Evaluate(1).Evaluate(z)).Evaluate(f1.Evaluate(5).Evaluate(z));

            Assert.Equal(8, f2.Evaluate(1));

            var result = f2.ExpandExpressions();

            NoDuplicateParameterAssertion.AssertNoDuplicateParameters(result);
            Assert.Equal(8, result.Evaluate(1));
            NoEvaluationsAssertion.AssertNoEvaluations(result);
        }

        [Fact]
        public void ExpandExpressionsVeryComplexTest2()
        {
            Expression<Func<int, Expression<Func<int, int>>>> f1 = x => (y => y + x);
            Expression<Func<int, int>> f2 =
                z => f1.Compile()(f1.Compile()(z).Compile()(1)).Compile()(f1.Compile()(z).Compile()(5));

            Assert.Equal(8, f2.Compile()(1));

            var result = f2.ExpandExpressions();

            NoDuplicateParameterAssertion.AssertNoDuplicateParameters(result);
            Assert.Equal(8, result.Compile()(1));
            NoEvaluationsAssertion.AssertNoEvaluations(result);
        }

        [Fact]
        public void ExpandExpressionsVeryComplexEvaluateTest2()
        {
            Expression<Func<int, Expression<Func<int, int>>>> f1 = x => (y => y + x);
            Expression<Func<int, int>> f2 =
                z => f1.Evaluate(f1.Evaluate(z).Evaluate(1)).Evaluate(f1.Evaluate(z).Evaluate(5));

            Assert.Equal(8, f2.Evaluate(1));

            var result = f2.ExpandExpressions();

            NoDuplicateParameterAssertion.AssertNoDuplicateParameters(result);
            Assert.Equal(8, result.Evaluate(1));
            NoEvaluationsAssertion.AssertNoEvaluations(result);
        }

        [Fact]
        public void ExpandExpressionsVeryComplexTest3()
        {
            Expression<Func<int, Expression<Func<int, int>>>> f1 = x => (y => y + x);
            Expression<Func<int, int>> f2 = z => f1.Compile()(z).Compile()(5);

            Assert.Equal(6, f2.Compile()(1));

            var result = f2.ExpandExpressions();

            NoDuplicateParameterAssertion.AssertNoDuplicateParameters(result);
            Assert.Equal(6, result.Compile()(1));
            NoEvaluationsAssertion.AssertNoEvaluations(result);
        }

        [Fact]
        public void ExpandExpressionsVeryComplexEvaluateTest3()
        {
            Expression<Func<int, Expression<Func<int, int>>>> f1 = x => (y => y + x);
            Expression<Func<int, int>> f2 = z => f1.Evaluate(z).Evaluate(5);

            Assert.Equal(6, f2.Evaluate(1));

            var result = f2.ExpandExpressions();

            NoDuplicateParameterAssertion.AssertNoDuplicateParameters(result);
            Assert.Equal(6, result.Evaluate(1));
            NoEvaluationsAssertion.AssertNoEvaluations(result);
        }

        [Fact]
        public void ExpandExpressionsVeryComplexTest4()
        {
            Expression<Func<int, Expression<Func<int, int>>>> f1 = x => (y => y + x);
            Expression<Func<int, int>> f2 =
                z => f1.Compile()(f1.Compile()(z).Compile()(1)).Compile()(6);

            Assert.Equal(8, f2.Compile()(1));

            var result = f2.ExpandExpressions();

            NoDuplicateParameterAssertion.AssertNoDuplicateParameters(result);
            Assert.Equal(8, result.Compile()(1));
            NoEvaluationsAssertion.AssertNoEvaluations(result);
        }

        [Fact]
        public void ExpandExpressionsVeryComplexEvaluateTest4()
        {
            Expression<Func<int, Expression<Func<int, int>>>> f1 = x => (y => y + x);
            Expression<Func<int, int>> f2 =
                z => f1.Evaluate(f1.Evaluate(z).Evaluate(1)).Evaluate(6);

            Assert.Equal(8, f2.Evaluate(1));

            var result = f2.ExpandExpressions();

            NoDuplicateParameterAssertion.AssertNoDuplicateParameters(result);
            Assert.Equal(8, result.Evaluate(1));
            NoEvaluationsAssertion.AssertNoEvaluations(result);
        }

        [Fact]
        public void ExpandExpressionsVeryComplexSameNamesTest1()
        {
            Expression<Func<int, Expression<Func<int, int>>>> f1 = x => (y => y + x);
            Expression<Func<int, int>> f2 =
                x => f1.Compile()(f1.Compile()(x).Compile()(1)).Compile()(f1.Compile()(x).Compile()(5));

            Assert.Equal(8, f2.Compile()(1));

            var result = f2.ExpandExpressions();

            NoDuplicateParameterAssertion.AssertNoDuplicateParameters(result);
            Assert.Equal(8, result.Compile()(1));
            NoEvaluationsAssertion.AssertNoEvaluations(result);
        }

        [Fact]
        public void ExpandExpressionsVeryComplexSameNamesEvaluateTest1()
        {
            Expression<Func<int, Expression<Func<int, int>>>> f1 = x => (y => y + x);
            Expression<Func<int, int>> f2 =
                x => f1.Evaluate(f1.Evaluate(x).Evaluate(1)).Evaluate(f1.Evaluate(x).Evaluate(5));

            Assert.Equal(8, f2.Evaluate(1));

            var result = f2.ExpandExpressions();

            NoDuplicateParameterAssertion.AssertNoDuplicateParameters(result);
            Assert.Equal(8, result.Evaluate(1));
            NoEvaluationsAssertion.AssertNoEvaluations(result);
        }

        [Fact]
        public void ExpandExpressionsVeryComplexSameNamesTest2()
        {
            Expression<Func<int, Expression<Func<int, int>>>> f1 = x => (y => y + x);
            Expression<Func<int, int>> f2 =
                y => f1.Compile()(f1.Compile()(y).Compile()(1)).Compile()(f1.Compile()(y).Compile()(5));

            Assert.Equal(8, f2.Compile()(1));

            var result = f2.ExpandExpressions();

            NoDuplicateParameterAssertion.AssertNoDuplicateParameters(result);
            Assert.Equal(8, result.Compile()(1));
            NoEvaluationsAssertion.AssertNoEvaluations(result);
        }

        [Fact]
        public void ExpandExpressionsVeryComplexSameNamesEvaluateTest2()
        {
            Expression<Func<int, Expression<Func<int, int>>>> f1 = x => (y => y + x);
            Expression<Func<int, int>> f2 =
                y => f1.Evaluate(f1.Evaluate(y).Evaluate(1)).Evaluate(f1.Evaluate(y).Evaluate(5));

            Assert.Equal(8, f2.Evaluate(1));

            var result = f2.ExpandExpressions();

            NoDuplicateParameterAssertion.AssertNoDuplicateParameters(result);
            Assert.Equal(8, result.Evaluate(1));
            NoEvaluationsAssertion.AssertNoEvaluations(result);
        }

        [Fact]
        public void ExpandExpressionsDirtyTest()
        {
            Expression<Func<int, Expression<Func<int, int>>>> f1 = x => (y => y + x);
            Expression<Func<int, int>> f2 =
                z => f1.Compile()(DirtyGetter(z).Compile()(1)).Compile()(f1.Compile()(5).Compile()(z));

            Assert.Equal(8, f2.Compile()(1));

            var result = f2.ExpandExpressions();

            NoDuplicateParameterAssertion.AssertNoDuplicateParameters(result);
            Assert.Equal(8, result.Compile()(1));
            // The result will have Compile calls cause DirtyGetter(z) cannot be expanded
        }

        [Fact]
        public void ExpandExpressionsDirtyEvaluateTest()
        {
            Expression<Func<int, Expression<Func<int, int>>>> f1 = x => (y => y + x);
            Expression<Func<int, int>> f2 =
                z => f1.Evaluate(DirtyGetter(z).Evaluate(1)).Evaluate(f1.Evaluate(5).Evaluate(z));

            Assert.Equal(8, f2.Evaluate(1));

            var result = f2.ExpandExpressions();

            NoDuplicateParameterAssertion.AssertNoDuplicateParameters(result);
            Assert.Equal(8, result.Evaluate(1));
            // The result will have Evaluate calls cause DirtyGetter(z) cannot be expanded
        }

        [Fact]
        public void ExpandExpressionsNonCompileInvocationTest()
        {
            Expression<Func<int, int>> f1 = x => GetGetter()() + x;

            Assert.Equal(2, f1.Compile()(1));

            var result = f1.ExpandExpressions();

            NoDuplicateParameterAssertion.AssertNoDuplicateParameters(result);
            Assert.Equal(2, result.Compile()(1));
            NoEvaluationsAssertion.AssertNoEvaluations(result);
        }

        [Fact]
        public void ExpandExpressionsFalseCompileTest()
        {
            Expression<Func<int, int>> f1 = x => x + 2;
            Expression<Func<int, Func<int, int>>> f2 = x => f1.Compile();
            var result = f2.ExpandExpressions();

            Assert.Equal(3, result.Evaluate(4)(1));
        }

        [Fact]
        public void ExpandExpressionsDuplicateParameterComlexTest()
        {
            Expression<Func<int, int>> f1 = x => new[] { x + 1 }.Single(y => y != x);
            Expression<Func<int, int>> f2 = x => x * x;
            Expression<Func<int, int>> f3 = x => f2.Evaluate(f1.Evaluate(x));

            var result = f3.ExpandExpressions();

            NoDuplicateParameterAssertion.AssertNoDuplicateParameters(result);
        }

        private static Expression<Func<int, int>> DirtyGetter(int argument)
        {
            return x => x + argument;
        }

        private static Func<int> GetGetter()
        {
            return () => 1;
        }

        private static Expression<Func<int, int>> Getter()
        {
            return x => x * 2;
        }

        private sealed class NoEvaluationsAssertion : ExpressionVisitor
        {
            private static readonly string CompileMethodName = nameof(Expression<Func<object>>.Compile);
            private NoEvaluationsAssertion() { }

            public static void AssertNoEvaluations(Expression expression)
            {
                new NoEvaluationsAssertion().Visit(expression);
            }

            protected override Expression VisitMethodCall(MethodCallExpression node)
            {
                ValidateMethod(node, node.Method);

                return base.VisitMethodCall(node);
            }

            protected override Expression VisitInvocation(InvocationExpression node)
            {
                if (node.Expression.NodeType == ExpressionType.Call)
                {
                    var methodCallExpression = (MethodCallExpression)node.Expression;
                    Assert.False(
                        (methodCallExpression.Method.DeclaringType != null) &&
                            methodCallExpression.Method.DeclaringType.IsConstructedGenericType &&
                            (methodCallExpression.Method.DeclaringType.GetGenericTypeDefinition() == typeof(Expression<>)) &&
                            (methodCallExpression.Method.Name == CompileMethodName),
                        $"The expression body has evaluation: \"{node}\".");
                }

                return base.VisitInvocation(node);
            }

            protected override Expression VisitConstant(ConstantExpression node)
            {
                if (node.Type == typeof(MethodInfo))
                    ValidateMethod(node, (MethodInfo)node.Value);

                return base.VisitConstant(node);
            }

            private static void ValidateMethod(Expression node, MethodInfo method)
            {
                if (node == null)
                    throw new ArgumentNullException(nameof(node));
                if (method == null)
                    throw new ArgumentNullException(nameof(method));

                Assert.False(
                    (method.DeclaringType == typeof(Extensions)) &&
                        (method.Name == ReflectionExpressions.GetMethodName<Expression<Func<object>>>(
                            expression => expression.Evaluate())),
                    $"The expression body has evaluation: \"{node}\".");
                Assert.False(
                    (method.DeclaringType != null) &&
                        (method.DeclaringType.GetTypeInfo().BaseType == typeof(MulticastDelegate)) &&
                        (method.Name == ReflectionExpressions.GetMethodName<Action>(action => action.Invoke())),
                    $"The expression body has invokation: \"{node}\".");
            }
        }

        private sealed class NoConvertAssertion : ExpressionVisitor
        {
            private NoConvertAssertion() { }

            public static void AssertNoConverts(Expression expression)
            {
                new NoConvertAssertion().Visit(expression);
            }

            protected override Expression VisitUnary(UnaryExpression node)
            {
                Assert.False(node.NodeType == ExpressionType.Convert, $"The expression body has convert: \"{node}\".");

                return base.VisitUnary(node);
            }
        }

        private sealed class NoDuplicateParameterAssertion : ExpressionVisitor
        {
            private readonly List<ParameterExpression> parameters = new List<ParameterExpression>();
            private NoDuplicateParameterAssertion() { }

            public static void AssertNoDuplicateParameters(Expression expression)
            {
                new NoDuplicateParameterAssertion().Visit(expression);
            }

            protected override Expression VisitLambda<T>(Expression<T> node)
            {
                foreach (var parameter in node.Parameters)
                {
                    Assert.False(parameters.Contains(parameter), $"Duplicate parameter detected: \"{parameter}\".");
                    parameters.Add(parameter);
                }

                return base.VisitLambda(node);
            }
        }
    }
}
