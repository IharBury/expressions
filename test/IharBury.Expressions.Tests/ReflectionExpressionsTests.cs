using System;
using System.Linq.Expressions;
using Xunit;

namespace IharBury.Expressions.Tests
{
    public class ReflectionExpressionsTests
    {
        [Fact]
        public void GetMethodInfoInstanceFunctionTest()
        {
            var result = ReflectionExpressions.GetMethodInfo<Test8>(methodObject => methodObject.Method1());
            Assert.Equal("Method1", result.Name);
        }

        [Fact]
        public void GetMethodInfoInstanceFunctionVariableTest()
        {
            Expression<Func<Test8, int>> expression = methodObject => methodObject.Method1();
            var result = ReflectionExpressions.GetMethodInfo(expression);
            Assert.Equal("Method1", result.Name);
        }

        [Fact]
        public void GetMethodInfoInstanceFunctionWithArgumentsTest()
        {
            var result = ReflectionExpressions.GetMethodInfo<Test8>(methodObject =>
                methodObject.Method2(default(string), default(int)));
            Assert.Equal("Method2", result.Name);
        }

        [Fact]
        public void GetMethodInfoInstanceVoidTest()
        {
            var result = ReflectionExpressions.GetMethodInfo<Test8>(methodObject => methodObject.Method3());
            Assert.Equal("Method3", result.Name);
        }

        [Fact]
        public void GetMethodInfoStaticVoidTest()
        {
            var result = ReflectionExpressions.GetMethodInfo(() => Test8.Method4());
            Assert.Equal("Method4", result.Name);
        }

        [Fact]
        public void GetMethodInfoStaticFunctionTest()
        {
            var result = ReflectionExpressions.GetMethodInfo(() => Test8.Method5());
            Assert.Equal("Method5", result.Name);
        }

        [Fact]
        public void GetMethodInfoStaticFunctionVariableTest()
        {
            Expression<Func<int>> expression = () => Test8.Method5();
            var result = ReflectionExpressions.GetMethodInfo(expression);
            Assert.Equal("Method5", result.Name);
        }

        [Fact]
        public void TryGetPropertyNameTest()
        {
            Expression<Func<Test2, object>> expression = test => test.X;
            Assert.Equal("X", ReflectionExpressions.TryGetPropertyName(expression));
        }

        [Fact]
        public void TryGetPropertyNameGenericInterfaceConstraintTest()
        {
            TryGetPropertyNameGeneric<Test3>();
        }

        [Fact]
        public void TryGetIndexedPropertyNameTest()
        {
            Expression<Func<Test2, object>> expression = test => test[default(string)];
            Assert.Equal("Item", ReflectionExpressions.TryGetPropertyName(expression));
        }

        [Fact]
        public void TryGetFieldNameTest()
        {
            Expression<Func<Test2, object>> expression = test => test.y;
            Assert.Equal("y", ReflectionExpressions.TryGetFieldName(expression));
        }

        [Fact]
        public void TryGetMethodNameNullTest1()
        {
            Assert.Null(ReflectionExpressions.TryGetMethodName((Expression<Func<object, object>>)null));
        }

        [Fact]
        public void TryGetMethodNameNullTest2()
        {
            Assert.Null(ReflectionExpressions.TryGetMethodName((Expression<Action<object>>)null));
        }

        [Fact]
        public void TryGetMethodNameNullTest3()
        {
            Assert.Null(ReflectionExpressions.TryGetMethodName((Expression<Func<object>>)null));
        }

        [Fact]
        public void TryGetMethodNameNullTest4()
        {
            Assert.Null(ReflectionExpressions.TryGetMethodName((Expression<Action>)null));
        }

        [Fact]
        public void TryGetMethodNameNullTest5()
        {
            Assert.Null(ReflectionExpressions.TryGetMethodName((LambdaExpression)null));
        }

        [Fact]
        public void TryGetPropertyNameNullTest1()
        {
            Assert.Null(ReflectionExpressions.TryGetPropertyName((Expression<Func<object, object>>)null));
        }

        [Fact]
        public void TryGetPropertyNameNullTest2()
        {
            Assert.Null(ReflectionExpressions.TryGetPropertyName((Expression<Func<object>>)null));
        }

        [Fact]
        public void TryGetPropertyNameNullTest3()
        {
            Assert.Null(ReflectionExpressions.TryGetPropertyName((LambdaExpression)null));
        }

        [Fact]
        public void TryGetFieldNameNullTest1()
        {
            Assert.Null(ReflectionExpressions.TryGetFieldName((Expression<Func<object, object>>)null));
        }

        [Fact]
        public void TryGetFieldNameNullTest2()
        {
            Assert.Null(ReflectionExpressions.TryGetFieldName((Expression<Func<object>>)null));
        }

        [Fact]
        public void TryGetFieldNameNullTest3()
        {
            Assert.Null(ReflectionExpressions.TryGetFieldName((LambdaExpression)null));
        }

        // When using interface and new() generic constraints, expression contains Convert to the interface.
        private void TryGetPropertyNameGeneric<T>()
            where T : ITest1, new()
        {
            Expression<Func<T, object>> expression = test => test.Y;
            Assert.Equal("Y", ReflectionExpressions.TryGetPropertyName(expression));
        }

        private interface ITest1
        {
            int Y { get; }
            Test2 Z { get; }
        }

        private class Test2
        {
            public int y = 1;
            public int X { get; set; }
            public int this[string key] => key?.Length ?? 0;
        }

        private class Test3 : Test2, ITest1
        {
            int ITest1.Y => 0;
            Test2 ITest1.Z => null;
        }

        private abstract class Test8
        {
            public static void Method4() { }

            public static int Method5() => 0;

            public abstract int Method1();
            public abstract int Method2(string x, int y);
            public abstract void Method3();
        }
    }
}
