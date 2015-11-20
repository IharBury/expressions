using System;
using System.Linq;
using System.Linq.Expressions;
using Xunit;

namespace IharBury.Expressions.Tests
{
    public class LambdaExpressionTests
    {
        [Fact]
        public void ExpressionWith0ParametersLambda()
        {
            var expression = Lambda.Expression(() => new { ResultProperty = 0 });
            Assert.Equal(typeof(Expression<>), expression.GetType().GetGenericTypeDefinition());
            expression.Compile().Invoke();
        }

        [Fact]
        public void ExpressionWith1ParameterLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var expression = Lambda.Expression(
                argument1Example,
                parameter1 => new { ResultProperty = 0 });
            Assert.Equal(typeof(Expression<>), expression.GetType().GetGenericTypeDefinition());
            expression.Compile().Invoke(argument1Example);
        }

        [Fact]
        public void ExpressionWith1ParameterLambdaWithParameterTypeFromEnumerable()
        {
            var argument1EnumerableExample = new[]
            {
                new
                {
                    Property1 = 1
                }
            };
            var expression = Lambda.Expression(
                argument1EnumerableExample.DefaultElement(),
                parameter1 => new { ResultProperty = 0 });
            Assert.Equal(typeof(Expression<>), expression.GetType().GetGenericTypeDefinition());
            expression.Compile().Invoke(argument1EnumerableExample.First());
        }

        [Fact]
        public void ExpressionWith2ParametersLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var argument2Example = new
            {
                Property2 = 2
            };
            var expression = Lambda.Expression(
                argument1Example,
                argument2Example,
                (parameter1, parameter2) => new { ResultProperty = 0 });
            Assert.Equal(typeof(Expression<>), expression.GetType().GetGenericTypeDefinition());
            expression.Compile().Invoke(argument1Example, argument2Example);
        }

        [Fact]
        public void ExpressionWith3ParametersLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var argument2Example = new
            {
                Property2 = 2
            };
            var argument3Example = new
            {
                Property3 = 3
            };
            var expression = Lambda.Expression(
                argument1Example,
                argument2Example,
                argument3Example,
                (parameter1, parameter2, parameter3) => new { ResultProperty = 0 });
            Assert.Equal(typeof(Expression<>), expression.GetType().GetGenericTypeDefinition());
            expression.Compile().Invoke(argument1Example, argument2Example, argument3Example);
        }

        [Fact]
        public void ExpressionWith4ParametersLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var argument2Example = new
            {
                Property2 = 2
            };
            var argument3Example = new
            {
                Property3 = 3
            };
            var argument4Example = new
            {
                Property4 = 4
            };
            var expression = Lambda.Expression(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                (parameter1, parameter2, parameter3, parameter4) => new { ResultProperty = 0 });
            Assert.Equal(typeof(Expression<>), expression.GetType().GetGenericTypeDefinition());
            expression.Compile().Invoke(argument1Example, argument2Example, argument3Example, argument4Example);
        }

#if !NET35 && !NET35_CLIENT
        [Fact]
        public void ExpressionWith5ParametersLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var argument2Example = new
            {
                Property2 = 2
            };
            var argument3Example = new
            {
                Property3 = 3
            };
            var argument4Example = new
            {
                Property4 = 4
            };
            var argument5Example = new
            {
                Property5 = 5
            };
            var expression = Lambda.Expression(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                (parameter1, parameter2, parameter3, parameter4, parameter5) => new { ResultProperty = 0 });
            Assert.Equal(typeof(Expression<>), expression.GetType().GetGenericTypeDefinition());
            expression.Compile().Invoke(argument1Example, argument2Example, argument3Example, argument4Example, argument5Example);
        }

        [Fact]
        public void ExpressionWith6ParametersLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var argument2Example = new
            {
                Property2 = 2
            };
            var argument3Example = new
            {
                Property3 = 3
            };
            var argument4Example = new
            {
                Property4 = 4
            };
            var argument5Example = new
            {
                Property5 = 5
            };
            var argument6Example = new
            {
                Property6 = 6
            };
            var expression = Lambda.Expression(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                (parameter1, parameter2, parameter3, parameter4, parameter5, parameter6) => new { ResultProperty = 0 });
            Assert.Equal(typeof(Expression<>), expression.GetType().GetGenericTypeDefinition());
            expression.Compile().Invoke(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example);
        }

        [Fact]
        public void ExpressionWith7ParametersLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var argument2Example = new
            {
                Property2 = 2
            };
            var argument3Example = new
            {
                Property3 = 3
            };
            var argument4Example = new
            {
                Property4 = 4
            };
            var argument5Example = new
            {
                Property5 = 5
            };
            var argument6Example = new
            {
                Property6 = 6
            };
            var argument7Example = new
            {
                Property7 = 7
            };
            var expression = Lambda.Expression(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                (parameter1,
                    parameter2,
                    parameter3,
                    parameter4,
                    parameter5,
                    parameter6,
                    parameter7) => new { ResultProperty = 0 });
            Assert.Equal(typeof(Expression<>), expression.GetType().GetGenericTypeDefinition());
            expression.Compile().Invoke(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example);
        }

        [Fact]
        public void ExpressionWith8ParametersLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var argument2Example = new
            {
                Property2 = 2
            };
            var argument3Example = new
            {
                Property3 = 3
            };
            var argument4Example = new
            {
                Property4 = 4
            };
            var argument5Example = new
            {
                Property5 = 5
            };
            var argument6Example = new
            {
                Property6 = 6
            };
            var argument7Example = new
            {
                Property7 = 7
            };
            var argument8Example = new
            {
                Property8 = 8
            };
            var expression = Lambda.Expression(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                (parameter1,
                    parameter2,
                    parameter3,
                    parameter4,
                    parameter5,
                    parameter6,
                    parameter7,
                    parameter8) => new { ResultProperty = 0 });
            Assert.Equal(typeof(Expression<>), expression.GetType().GetGenericTypeDefinition());
            expression.Compile().Invoke(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example);
        }

        [Fact]
        public void ExpressionWith9ParametersLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var argument2Example = new
            {
                Property2 = 2
            };
            var argument3Example = new
            {
                Property3 = 3
            };
            var argument4Example = new
            {
                Property4 = 4
            };
            var argument5Example = new
            {
                Property5 = 5
            };
            var argument6Example = new
            {
                Property6 = 6
            };
            var argument7Example = new
            {
                Property7 = 7
            };
            var argument8Example = new
            {
                Property8 = 8
            };
            var argument9Example = new
            {
                Property9 = 9
            };
            var expression = Lambda.Expression(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example,
                (parameter1,
                    parameter2,
                    parameter3,
                    parameter4,
                    parameter5,
                    parameter6,
                    parameter7,
                    parameter8,
                    parameter9) => new { ResultProperty = 0 });
            Assert.Equal(typeof(Expression<>), expression.GetType().GetGenericTypeDefinition());
            expression.Compile().Invoke(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example);
        }

        [Fact]
        public void ExpressionWith10ParametersLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var argument2Example = new
            {
                Property2 = 2
            };
            var argument3Example = new
            {
                Property3 = 3
            };
            var argument4Example = new
            {
                Property4 = 4
            };
            var argument5Example = new
            {
                Property5 = 5
            };
            var argument6Example = new
            {
                Property6 = 6
            };
            var argument7Example = new
            {
                Property7 = 7
            };
            var argument8Example = new
            {
                Property8 = 8
            };
            var argument9Example = new
            {
                Property9 = 9
            };
            var argument10Example = new
            {
                Property10 = 10
            };
            var expression = Lambda.Expression(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example,
                argument10Example,
                (parameter1,
                    parameter2,
                    parameter3,
                    parameter4,
                    parameter5,
                    parameter6,
                    parameter7,
                    parameter8,
                    parameter9,
                    parameter10) => new { ResultProperty = 0 });
            Assert.Equal(typeof(Expression<>), expression.GetType().GetGenericTypeDefinition());
            expression.Compile().Invoke(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example,
                argument10Example);
        }

        [Fact]
        public void ExpressionWith11ParametersLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var argument2Example = new
            {
                Property2 = 2
            };
            var argument3Example = new
            {
                Property3 = 3
            };
            var argument4Example = new
            {
                Property4 = 4
            };
            var argument5Example = new
            {
                Property5 = 5
            };
            var argument6Example = new
            {
                Property6 = 6
            };
            var argument7Example = new
            {
                Property7 = 7
            };
            var argument8Example = new
            {
                Property8 = 8
            };
            var argument9Example = new
            {
                Property9 = 9
            };
            var argument10Example = new
            {
                Property10 = 10
            };
            var argument11Example = new
            {
                Property11 = 11
            };
            var expression = Lambda.Expression(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example,
                argument10Example,
                argument11Example,
                (parameter1,
                    parameter2,
                    parameter3,
                    parameter4,
                    parameter5,
                    parameter6,
                    parameter7,
                    parameter8,
                    parameter9,
                    parameter10,
                    parameter11) => new { ResultProperty = 0 });
            Assert.Equal(typeof(Expression<>), expression.GetType().GetGenericTypeDefinition());
            expression.Compile().Invoke(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example,
                argument10Example,
                argument11Example);
        }

        [Fact]
        public void ExpressionWith12ParametersLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var argument2Example = new
            {
                Property2 = 2
            };
            var argument3Example = new
            {
                Property3 = 3
            };
            var argument4Example = new
            {
                Property4 = 4
            };
            var argument5Example = new
            {
                Property5 = 5
            };
            var argument6Example = new
            {
                Property6 = 6
            };
            var argument7Example = new
            {
                Property7 = 7
            };
            var argument8Example = new
            {
                Property8 = 8
            };
            var argument9Example = new
            {
                Property9 = 9
            };
            var argument10Example = new
            {
                Property10 = 10
            };
            var argument11Example = new
            {
                Property11 = 11
            };
            var argument12Example = new
            {
                Property12 = 12
            };
            var expression = Lambda.Expression(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example,
                argument10Example,
                argument11Example,
                argument12Example,
                (parameter1,
                    parameter2,
                    parameter3,
                    parameter4,
                    parameter5,
                    parameter6,
                    parameter7,
                    parameter8,
                    parameter9,
                    parameter10,
                    parameter11,
                    parameter12) => new { ResultProperty = 0 });
            Assert.Equal(typeof(Expression<>), expression.GetType().GetGenericTypeDefinition());
            expression.Compile().Invoke(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example,
                argument10Example,
                argument11Example,
                argument12Example);
        }

        [Fact]
        public void ExpressionWith13ParametersLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var argument2Example = new
            {
                Property2 = 2
            };
            var argument3Example = new
            {
                Property3 = 3
            };
            var argument4Example = new
            {
                Property4 = 4
            };
            var argument5Example = new
            {
                Property5 = 5
            };
            var argument6Example = new
            {
                Property6 = 6
            };
            var argument7Example = new
            {
                Property7 = 7
            };
            var argument8Example = new
            {
                Property8 = 8
            };
            var argument9Example = new
            {
                Property9 = 9
            };
            var argument10Example = new
            {
                Property10 = 10
            };
            var argument11Example = new
            {
                Property11 = 11
            };
            var argument12Example = new
            {
                Property12 = 12
            };
            var argument13Example = new
            {
                Property13 = 13
            };
            var expression = Lambda.Expression(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example,
                argument10Example,
                argument11Example,
                argument12Example,
                argument13Example,
                (parameter1,
                    parameter2,
                    parameter3,
                    parameter4,
                    parameter5,
                    parameter6,
                    parameter7,
                    parameter8,
                    parameter9,
                    parameter10,
                    parameter11,
                    parameter12,
                    parameter13) => new { ResultProperty = 0 });
            Assert.Equal(typeof(Expression<>), expression.GetType().GetGenericTypeDefinition());
            expression.Compile().Invoke(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example,
                argument10Example,
                argument11Example,
                argument12Example,
                argument13Example);
        }

        [Fact]
        public void ExpressionWith14ParametersLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var argument2Example = new
            {
                Property2 = 2
            };
            var argument3Example = new
            {
                Property3 = 3
            };
            var argument4Example = new
            {
                Property4 = 4
            };
            var argument5Example = new
            {
                Property5 = 5
            };
            var argument6Example = new
            {
                Property6 = 6
            };
            var argument7Example = new
            {
                Property7 = 7
            };
            var argument8Example = new
            {
                Property8 = 8
            };
            var argument9Example = new
            {
                Property9 = 9
            };
            var argument10Example = new
            {
                Property10 = 10
            };
            var argument11Example = new
            {
                Property11 = 11
            };
            var argument12Example = new
            {
                Property12 = 12
            };
            var argument13Example = new
            {
                Property13 = 13
            };
            var argument14Example = new
            {
                Property14 = 14
            };
            var expression = Lambda.Expression(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example,
                argument10Example,
                argument11Example,
                argument12Example,
                argument13Example,
                argument14Example,
                (parameter1,
                    parameter2,
                    parameter3,
                    parameter4,
                    parameter5,
                    parameter6,
                    parameter7,
                    parameter8,
                    parameter9,
                    parameter10,
                    parameter11,
                    parameter12,
                    parameter13,
                    parameter14) => new { ResultProperty = 0 });
            Assert.Equal(typeof(Expression<>), expression.GetType().GetGenericTypeDefinition());
            expression.Compile().Invoke(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example,
                argument10Example,
                argument11Example,
                argument12Example,
                argument13Example,
                argument14Example);
        }

        [Fact]
        public void ExpressionWith15ParametersLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var argument2Example = new
            {
                Property2 = 2
            };
            var argument3Example = new
            {
                Property3 = 3
            };
            var argument4Example = new
            {
                Property4 = 4
            };
            var argument5Example = new
            {
                Property5 = 5
            };
            var argument6Example = new
            {
                Property6 = 6
            };
            var argument7Example = new
            {
                Property7 = 7
            };
            var argument8Example = new
            {
                Property8 = 8
            };
            var argument9Example = new
            {
                Property9 = 9
            };
            var argument10Example = new
            {
                Property10 = 10
            };
            var argument11Example = new
            {
                Property11 = 11
            };
            var argument12Example = new
            {
                Property12 = 12
            };
            var argument13Example = new
            {
                Property13 = 13
            };
            var argument14Example = new
            {
                Property14 = 14
            };
            var argument15Example = new
            {
                Property15 = 15
            };
            var expression = Lambda.Expression(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example,
                argument10Example,
                argument11Example,
                argument12Example,
                argument13Example,
                argument14Example,
                argument15Example,
                (parameter1,
                    parameter2,
                    parameter3,
                    parameter4,
                    parameter5,
                    parameter6,
                    parameter7,
                    parameter8,
                    parameter9,
                    parameter10,
                    parameter11,
                    parameter12,
                    parameter13,
                    parameter14,
                    parameter15) => new { ResultProperty = 0 });
            Assert.Equal(typeof(Expression<>), expression.GetType().GetGenericTypeDefinition());
            expression.Compile().Invoke(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example,
                argument10Example,
                argument11Example,
                argument12Example,
                argument13Example,
                argument14Example,
                argument15Example);
        }

        [Fact]
        public void ExpressionWith16ParametersLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var argument2Example = new
            {
                Property2 = 2
            };
            var argument3Example = new
            {
                Property3 = 3
            };
            var argument4Example = new
            {
                Property4 = 4
            };
            var argument5Example = new
            {
                Property5 = 5
            };
            var argument6Example = new
            {
                Property6 = 6
            };
            var argument7Example = new
            {
                Property7 = 7
            };
            var argument8Example = new
            {
                Property8 = 8
            };
            var argument9Example = new
            {
                Property9 = 9
            };
            var argument10Example = new
            {
                Property10 = 10
            };
            var argument11Example = new
            {
                Property11 = 11
            };
            var argument12Example = new
            {
                Property12 = 12
            };
            var argument13Example = new
            {
                Property13 = 13
            };
            var argument14Example = new
            {
                Property14 = 14
            };
            var argument15Example = new
            {
                Property15 = 15
            };
            var argument16Example = new
            {
                Property16 = 16
            };
            var expression = Lambda.Expression(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example,
                argument10Example,
                argument11Example,
                argument12Example,
                argument13Example,
                argument14Example,
                argument15Example,
                argument16Example,
                (parameter1,
                    parameter2,
                    parameter3,
                    parameter4,
                    parameter5,
                    parameter6,
                    parameter7,
                    parameter8,
                    parameter9,
                    parameter10,
                    parameter11,
                    parameter12,
                    parameter13,
                    parameter14,
                    parameter15,
                    parameter16) => new { ResultProperty = 0 });
            Assert.Equal(typeof(Expression<>), expression.GetType().GetGenericTypeDefinition());
            expression.Compile().Invoke(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example,
                argument10Example,
                argument11Example,
                argument12Example,
                argument13Example,
                argument14Example,
                argument15Example,
                argument16Example);
        }
#endif

        [Fact]
        public void FuncWith0ParametersLambda()
        {
            var lambdaDelegate = Lambda.Func(() => new { ResultProperty = 0 });
            Assert.IsAssignableFrom<Delegate>(lambdaDelegate);
            lambdaDelegate();
        }

        [Fact]
        public void FuncWith1ParameterLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var lambdaDelegate = Lambda.Func(
                argument1Example,
                parameter1 => new { ResultProperty = 0 });
            Assert.IsAssignableFrom<Delegate>(lambdaDelegate);
            lambdaDelegate(argument1Example);
        }

        [Fact]
        public void FuncWith2ParametersLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var argument2Example = new
            {
                Property2 = 2
            };
            var lambdaDelegate = Lambda.Func(
                argument1Example,
                argument2Example,
                (parameter1, parameter2) => new { ResultProperty = 0 });
            Assert.IsAssignableFrom<Delegate>(lambdaDelegate);
            lambdaDelegate(argument1Example, argument2Example);
        }

        [Fact]
        public void FuncWith3ParametersLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var argument2Example = new
            {
                Property2 = 2
            };
            var argument3Example = new
            {
                Property3 = 3
            };
            var lambdaDelegate = Lambda.Func(
                argument1Example,
                argument2Example,
                argument3Example,
                (parameter1, parameter2, parameter3) => new { ResultProperty = 0 });
            Assert.IsAssignableFrom<Delegate>(lambdaDelegate);
            lambdaDelegate(argument1Example, argument2Example, argument3Example);
        }

        [Fact]
        public void FuncWith4ParametersLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var argument2Example = new
            {
                Property2 = 2
            };
            var argument3Example = new
            {
                Property3 = 3
            };
            var argument4Example = new
            {
                Property4 = 4
            };
            var lambdaDelegate = Lambda.Func(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                (parameter1, parameter2, parameter3, parameter4) => new { ResultProperty = 0 });
            Assert.IsAssignableFrom<Delegate>(lambdaDelegate);
            lambdaDelegate(argument1Example, argument2Example, argument3Example, argument4Example);
        }

#if !NET35 && !NET35_CLIENT
        [Fact]
        public void FuncWith5ParametersLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var argument2Example = new
            {
                Property2 = 2
            };
            var argument3Example = new
            {
                Property3 = 3
            };
            var argument4Example = new
            {
                Property4 = 4
            };
            var argument5Example = new
            {
                Property5 = 5
            };
            var lambdaDelegate = Lambda.Func(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                (parameter1, parameter2, parameter3, parameter4, parameter5) => new { ResultProperty = 0 });
            Assert.IsAssignableFrom<Delegate>(lambdaDelegate);
            lambdaDelegate(argument1Example, argument2Example, argument3Example, argument4Example, argument5Example);
        }

        [Fact]
        public void FuncWith6ParametersLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var argument2Example = new
            {
                Property2 = 2
            };
            var argument3Example = new
            {
                Property3 = 3
            };
            var argument4Example = new
            {
                Property4 = 4
            };
            var argument5Example = new
            {
                Property5 = 5
            };
            var argument6Example = new
            {
                Property6 = 6
            };
            var lambdaDelegate = Lambda.Func(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                (parameter1, parameter2, parameter3, parameter4, parameter5, parameter6) => new { ResultProperty = 0 });
            Assert.IsAssignableFrom<Delegate>(lambdaDelegate);
            lambdaDelegate(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example);
        }

        [Fact]
        public void FuncWith7ParametersLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var argument2Example = new
            {
                Property2 = 2
            };
            var argument3Example = new
            {
                Property3 = 3
            };
            var argument4Example = new
            {
                Property4 = 4
            };
            var argument5Example = new
            {
                Property5 = 5
            };
            var argument6Example = new
            {
                Property6 = 6
            };
            var argument7Example = new
            {
                Property7 = 7
            };
            var lambdaDelegate = Lambda.Func(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                (parameter1,
                    parameter2,
                    parameter3,
                    parameter4,
                    parameter5,
                    parameter6,
                    parameter7) => new { ResultProperty = 0 });
            Assert.IsAssignableFrom<Delegate>(lambdaDelegate);
            lambdaDelegate(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example);
        }

        [Fact]
        public void FuncWith8ParametersLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var argument2Example = new
            {
                Property2 = 2
            };
            var argument3Example = new
            {
                Property3 = 3
            };
            var argument4Example = new
            {
                Property4 = 4
            };
            var argument5Example = new
            {
                Property5 = 5
            };
            var argument6Example = new
            {
                Property6 = 6
            };
            var argument7Example = new
            {
                Property7 = 7
            };
            var argument8Example = new
            {
                Property8 = 8
            };
            var lambdaDelegate = Lambda.Func(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                (parameter1,
                    parameter2,
                    parameter3,
                    parameter4,
                    parameter5,
                    parameter6,
                    parameter7,
                    parameter8) => new { ResultProperty = 0 });
            Assert.IsAssignableFrom<Delegate>(lambdaDelegate);
            lambdaDelegate(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example);
        }

        [Fact]
        public void FuncWith9ParametersLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var argument2Example = new
            {
                Property2 = 2
            };
            var argument3Example = new
            {
                Property3 = 3
            };
            var argument4Example = new
            {
                Property4 = 4
            };
            var argument5Example = new
            {
                Property5 = 5
            };
            var argument6Example = new
            {
                Property6 = 6
            };
            var argument7Example = new
            {
                Property7 = 7
            };
            var argument8Example = new
            {
                Property8 = 8
            };
            var argument9Example = new
            {
                Property9 = 9
            };
            var lambdaDelegate = Lambda.Func(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example,
                (parameter1,
                    parameter2,
                    parameter3,
                    parameter4,
                    parameter5,
                    parameter6,
                    parameter7,
                    parameter8,
                    parameter9) => new { ResultProperty = 0 });
            Assert.IsAssignableFrom<Delegate>(lambdaDelegate);
            lambdaDelegate(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example);
        }

        [Fact]
        public void FuncWith10ParametersLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var argument2Example = new
            {
                Property2 = 2
            };
            var argument3Example = new
            {
                Property3 = 3
            };
            var argument4Example = new
            {
                Property4 = 4
            };
            var argument5Example = new
            {
                Property5 = 5
            };
            var argument6Example = new
            {
                Property6 = 6
            };
            var argument7Example = new
            {
                Property7 = 7
            };
            var argument8Example = new
            {
                Property8 = 8
            };
            var argument9Example = new
            {
                Property9 = 9
            };
            var argument10Example = new
            {
                Property10 = 10
            };
            var lambdaDelegate = Lambda.Func(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example,
                argument10Example,
                (parameter1,
                    parameter2,
                    parameter3,
                    parameter4,
                    parameter5,
                    parameter6,
                    parameter7,
                    parameter8,
                    parameter9,
                    parameter10) => new { ResultProperty = 0 });
            Assert.IsAssignableFrom<Delegate>(lambdaDelegate);
            lambdaDelegate(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example,
                argument10Example);
        }

        [Fact]
        public void FuncWith11ParametersLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var argument2Example = new
            {
                Property2 = 2
            };
            var argument3Example = new
            {
                Property3 = 3
            };
            var argument4Example = new
            {
                Property4 = 4
            };
            var argument5Example = new
            {
                Property5 = 5
            };
            var argument6Example = new
            {
                Property6 = 6
            };
            var argument7Example = new
            {
                Property7 = 7
            };
            var argument8Example = new
            {
                Property8 = 8
            };
            var argument9Example = new
            {
                Property9 = 9
            };
            var argument10Example = new
            {
                Property10 = 10
            };
            var argument11Example = new
            {
                Property11 = 11
            };
            var lambdaDelegate = Lambda.Func(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example,
                argument10Example,
                argument11Example,
                (parameter1,
                    parameter2,
                    parameter3,
                    parameter4,
                    parameter5,
                    parameter6,
                    parameter7,
                    parameter8,
                    parameter9,
                    parameter10,
                    parameter11) => new { ResultProperty = 0 });
            Assert.IsAssignableFrom<Delegate>(lambdaDelegate);
            lambdaDelegate(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example,
                argument10Example,
                argument11Example);
        }

        [Fact]
        public void FuncWith12ParametersLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var argument2Example = new
            {
                Property2 = 2
            };
            var argument3Example = new
            {
                Property3 = 3
            };
            var argument4Example = new
            {
                Property4 = 4
            };
            var argument5Example = new
            {
                Property5 = 5
            };
            var argument6Example = new
            {
                Property6 = 6
            };
            var argument7Example = new
            {
                Property7 = 7
            };
            var argument8Example = new
            {
                Property8 = 8
            };
            var argument9Example = new
            {
                Property9 = 9
            };
            var argument10Example = new
            {
                Property10 = 10
            };
            var argument11Example = new
            {
                Property11 = 11
            };
            var argument12Example = new
            {
                Property12 = 12
            };
            var lambdaDelegate = Lambda.Func(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example,
                argument10Example,
                argument11Example,
                argument12Example,
                (parameter1,
                    parameter2,
                    parameter3,
                    parameter4,
                    parameter5,
                    parameter6,
                    parameter7,
                    parameter8,
                    parameter9,
                    parameter10,
                    parameter11,
                    parameter12) => new { ResultProperty = 0 });
            Assert.IsAssignableFrom<Delegate>(lambdaDelegate);
            lambdaDelegate(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example,
                argument10Example,
                argument11Example,
                argument12Example);
        }

        [Fact]
        public void FuncWith13ParametersLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var argument2Example = new
            {
                Property2 = 2
            };
            var argument3Example = new
            {
                Property3 = 3
            };
            var argument4Example = new
            {
                Property4 = 4
            };
            var argument5Example = new
            {
                Property5 = 5
            };
            var argument6Example = new
            {
                Property6 = 6
            };
            var argument7Example = new
            {
                Property7 = 7
            };
            var argument8Example = new
            {
                Property8 = 8
            };
            var argument9Example = new
            {
                Property9 = 9
            };
            var argument10Example = new
            {
                Property10 = 10
            };
            var argument11Example = new
            {
                Property11 = 11
            };
            var argument12Example = new
            {
                Property12 = 12
            };
            var argument13Example = new
            {
                Property13 = 13
            };
            var lambdaDelegate = Lambda.Func(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example,
                argument10Example,
                argument11Example,
                argument12Example,
                argument13Example,
                (parameter1,
                    parameter2,
                    parameter3,
                    parameter4,
                    parameter5,
                    parameter6,
                    parameter7,
                    parameter8,
                    parameter9,
                    parameter10,
                    parameter11,
                    parameter12,
                    parameter13) => new { ResultProperty = 0 });
            Assert.IsAssignableFrom<Delegate>(lambdaDelegate);
            lambdaDelegate(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example,
                argument10Example,
                argument11Example,
                argument12Example,
                argument13Example);
        }

        [Fact]
        public void FuncWith14ParametersLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var argument2Example = new
            {
                Property2 = 2
            };
            var argument3Example = new
            {
                Property3 = 3
            };
            var argument4Example = new
            {
                Property4 = 4
            };
            var argument5Example = new
            {
                Property5 = 5
            };
            var argument6Example = new
            {
                Property6 = 6
            };
            var argument7Example = new
            {
                Property7 = 7
            };
            var argument8Example = new
            {
                Property8 = 8
            };
            var argument9Example = new
            {
                Property9 = 9
            };
            var argument10Example = new
            {
                Property10 = 10
            };
            var argument11Example = new
            {
                Property11 = 11
            };
            var argument12Example = new
            {
                Property12 = 12
            };
            var argument13Example = new
            {
                Property13 = 13
            };
            var argument14Example = new
            {
                Property14 = 14
            };
            var lambdaDelegate = Lambda.Func(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example,
                argument10Example,
                argument11Example,
                argument12Example,
                argument13Example,
                argument14Example,
                (parameter1,
                    parameter2,
                    parameter3,
                    parameter4,
                    parameter5,
                    parameter6,
                    parameter7,
                    parameter8,
                    parameter9,
                    parameter10,
                    parameter11,
                    parameter12,
                    parameter13,
                    parameter14) => new { ResultProperty = 0 });
            Assert.IsAssignableFrom<Delegate>(lambdaDelegate);
            lambdaDelegate(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example,
                argument10Example,
                argument11Example,
                argument12Example,
                argument13Example,
                argument14Example);
        }

        [Fact]
        public void FuncWith15ParametersLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var argument2Example = new
            {
                Property2 = 2
            };
            var argument3Example = new
            {
                Property3 = 3
            };
            var argument4Example = new
            {
                Property4 = 4
            };
            var argument5Example = new
            {
                Property5 = 5
            };
            var argument6Example = new
            {
                Property6 = 6
            };
            var argument7Example = new
            {
                Property7 = 7
            };
            var argument8Example = new
            {
                Property8 = 8
            };
            var argument9Example = new
            {
                Property9 = 9
            };
            var argument10Example = new
            {
                Property10 = 10
            };
            var argument11Example = new
            {
                Property11 = 11
            };
            var argument12Example = new
            {
                Property12 = 12
            };
            var argument13Example = new
            {
                Property13 = 13
            };
            var argument14Example = new
            {
                Property14 = 14
            };
            var argument15Example = new
            {
                Property15 = 15
            };
            var lambdaDelegate = Lambda.Func(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example,
                argument10Example,
                argument11Example,
                argument12Example,
                argument13Example,
                argument14Example,
                argument15Example,
                (parameter1,
                    parameter2,
                    parameter3,
                    parameter4,
                    parameter5,
                    parameter6,
                    parameter7,
                    parameter8,
                    parameter9,
                    parameter10,
                    parameter11,
                    parameter12,
                    parameter13,
                    parameter14,
                    parameter15) => new { ResultProperty = 0 });
            Assert.IsAssignableFrom<Delegate>(lambdaDelegate);
            lambdaDelegate(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example,
                argument10Example,
                argument11Example,
                argument12Example,
                argument13Example,
                argument14Example,
                argument15Example);
        }

        [Fact]
        public void FuncWith16ParametersLambda()
        {
            var argument1Example = new
            {
                Property1 = 1
            };
            var argument2Example = new
            {
                Property2 = 2
            };
            var argument3Example = new
            {
                Property3 = 3
            };
            var argument4Example = new
            {
                Property4 = 4
            };
            var argument5Example = new
            {
                Property5 = 5
            };
            var argument6Example = new
            {
                Property6 = 6
            };
            var argument7Example = new
            {
                Property7 = 7
            };
            var argument8Example = new
            {
                Property8 = 8
            };
            var argument9Example = new
            {
                Property9 = 9
            };
            var argument10Example = new
            {
                Property10 = 10
            };
            var argument11Example = new
            {
                Property11 = 11
            };
            var argument12Example = new
            {
                Property12 = 12
            };
            var argument13Example = new
            {
                Property13 = 13
            };
            var argument14Example = new
            {
                Property14 = 14
            };
            var argument15Example = new
            {
                Property15 = 15
            };
            var argument16Example = new
            {
                Property16 = 16
            };
            var lambdaDelegate = Lambda.Func(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example,
                argument10Example,
                argument11Example,
                argument12Example,
                argument13Example,
                argument14Example,
                argument15Example,
                argument16Example,
                (parameter1,
                    parameter2,
                    parameter3,
                    parameter4,
                    parameter5,
                    parameter6,
                    parameter7,
                    parameter8,
                    parameter9,
                    parameter10,
                    parameter11,
                    parameter12,
                    parameter13,
                    parameter14,
                    parameter15,
                    parameter16) => new { ResultProperty = 0 });
            Assert.IsAssignableFrom<Delegate>(lambdaDelegate);
            lambdaDelegate(
                argument1Example,
                argument2Example,
                argument3Example,
                argument4Example,
                argument5Example,
                argument6Example,
                argument7Example,
                argument8Example,
                argument9Example,
                argument10Example,
                argument11Example,
                argument12Example,
                argument13Example,
                argument14Example,
                argument15Example,
                argument16Example);
        }
#endif
    }
}
