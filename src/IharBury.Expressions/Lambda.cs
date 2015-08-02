using System;
using System.Linq.Expressions;

namespace IharBury.Expressions
{
    /// <summary>
    /// Contains methods to build expressions and delegates with anonymous types.
    /// </summary>
    public static class Lambda
    {
        /// <summary>
        /// Returns lambda as expression.
        /// </summary>
        /// <typeparam name="TResult">Expression result type.</typeparam>
        /// <param name="lambda">Lambda to be treated as expression.</param>
        /// <returns>Expression from lambda.</returns>
        public static Expression<Func<TResult>> Expression<TResult>(Expression<Func<TResult>> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as expression.
        /// </summary>
        /// <typeparam name="TResult">Expression result type.</typeparam>
        /// <typeparam name="T1">Expression argument #1 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="lambda">Lambda to be treated as expression.</param>
        /// <returns>Expression from lambda.</returns>
        public static Expression<Func<T1, TResult>> Expression<T1, TResult>(
            T1 argument1Example,
            Expression<Func<T1, TResult>> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as expression.
        /// </summary>
        /// <typeparam name="TResult">Expression result type.</typeparam>
        /// <typeparam name="T1">Expression argument #1 type.</typeparam>
        /// <typeparam name="T2">Expression argument #2 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="argument2Example">Any argument with compile-time type of argument #2.</param>
        /// <param name="lambda">Lambda to be treated as expression.</param>
        /// <returns>Expression from lambda.</returns>
        public static Expression<Func<T1, T2, TResult>> Expression<T1, T2, TResult>(
            T1 argument1Example,
            T2 argument2Example,
            Expression<Func<T1, T2, TResult>> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as expression.
        /// </summary>
        /// <typeparam name="TResult">Expression result type.</typeparam>
        /// <typeparam name="T1">Expression argument #1 type.</typeparam>
        /// <typeparam name="T2">Expression argument #2 type.</typeparam>
        /// <typeparam name="T3">Expression argument #3 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="argument2Example">Any argument with compile-time type of argument #2.</param>
        /// <param name="argument3Example">Any argument with compile-time type of argument #3.</param>
        /// <param name="lambda">Lambda to be treated as expression.</param>
        /// <returns>Expression from lambda.</returns>
        public static Expression<Func<T1, T2, T3, TResult>> Expression<T1, T2, T3, TResult>(
            T1 argument1Example,
            T2 argument2Example,
            T3 argument3Example,
            Expression<Func<T1, T2, T3, TResult>> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as expression.
        /// </summary>
        /// <typeparam name="TResult">Expression result type.</typeparam>
        /// <typeparam name="T1">Expression argument #1 type.</typeparam>
        /// <typeparam name="T2">Expression argument #2 type.</typeparam>
        /// <typeparam name="T3">Expression argument #3 type.</typeparam>
        /// <typeparam name="T4">Expression argument #4 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="argument2Example">Any argument with compile-time type of argument #2.</param>
        /// <param name="argument3Example">Any argument with compile-time type of argument #3.</param>
        /// <param name="argument4Example">Any argument with compile-time type of argument #4.</param>
        /// <param name="lambda">Lambda to be treated as expression.</param>
        /// <returns>Expression from lambda.</returns>
        public static Expression<Func<T1, T2, T3, T4, TResult>> Expression<T1, T2, T3, T4, TResult>(
            T1 argument1Example,
            T2 argument2Example,
            T3 argument3Example,
            T4 argument4Example,
            Expression<Func<T1, T2, T3, T4, TResult>> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as expression.
        /// </summary>
        /// <typeparam name="TResult">Expression result type.</typeparam>
        /// <typeparam name="T1">Expression argument #1 type.</typeparam>
        /// <typeparam name="T2">Expression argument #2 type.</typeparam>
        /// <typeparam name="T3">Expression argument #3 type.</typeparam>
        /// <typeparam name="T4">Expression argument #4 type.</typeparam>
        /// <typeparam name="T5">Expression argument #5 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="argument2Example">Any argument with compile-time type of argument #2.</param>
        /// <param name="argument3Example">Any argument with compile-time type of argument #3.</param>
        /// <param name="argument4Example">Any argument with compile-time type of argument #4.</param>
        /// <param name="argument5Example">Any argument with compile-time type of argument #5.</param>
        /// <param name="lambda">Lambda to be treated as expression.</param>
        /// <returns>Expression from lambda.</returns>
        public static Expression<Func<T1, T2, T3, T4, T5, TResult>> Expression<T1, T2, T3, T4, T5, TResult>(
            T1 argument1Example,
            T2 argument2Example,
            T3 argument3Example,
            T4 argument4Example,
            T5 argument5Example,
            Expression<Func<T1, T2, T3, T4, T5, TResult>> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as expression.
        /// </summary>
        /// <typeparam name="TResult">Expression result type.</typeparam>
        /// <typeparam name="T1">Expression argument #1 type.</typeparam>
        /// <typeparam name="T2">Expression argument #2 type.</typeparam>
        /// <typeparam name="T3">Expression argument #3 type.</typeparam>
        /// <typeparam name="T4">Expression argument #4 type.</typeparam>
        /// <typeparam name="T5">Expression argument #5 type.</typeparam>
        /// <typeparam name="T6">Expression argument #6 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="argument2Example">Any argument with compile-time type of argument #2.</param>
        /// <param name="argument3Example">Any argument with compile-time type of argument #3.</param>
        /// <param name="argument4Example">Any argument with compile-time type of argument #4.</param>
        /// <param name="argument5Example">Any argument with compile-time type of argument #5.</param>
        /// <param name="argument6Example">Any argument with compile-time type of argument #6.</param>
        /// <param name="lambda">Lambda to be treated as expression.</param>
        /// <returns>Expression from lambda.</returns>
        public static Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> Expression<T1, T2, T3, T4, T5, T6, TResult>(
            T1 argument1Example,
            T2 argument2Example,
            T3 argument3Example,
            T4 argument4Example,
            T5 argument5Example,
            T6 argument6Example,
            Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as expression.
        /// </summary>
        /// <typeparam name="TResult">Expression result type.</typeparam>
        /// <typeparam name="T1">Expression argument #1 type.</typeparam>
        /// <typeparam name="T2">Expression argument #2 type.</typeparam>
        /// <typeparam name="T3">Expression argument #3 type.</typeparam>
        /// <typeparam name="T4">Expression argument #4 type.</typeparam>
        /// <typeparam name="T5">Expression argument #5 type.</typeparam>
        /// <typeparam name="T6">Expression argument #6 type.</typeparam>
        /// <typeparam name="T7">Expression argument #7 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="argument2Example">Any argument with compile-time type of argument #2.</param>
        /// <param name="argument3Example">Any argument with compile-time type of argument #3.</param>
        /// <param name="argument4Example">Any argument with compile-time type of argument #4.</param>
        /// <param name="argument5Example">Any argument with compile-time type of argument #5.</param>
        /// <param name="argument6Example">Any argument with compile-time type of argument #6.</param>
        /// <param name="argument7Example">Any argument with compile-time type of argument #7.</param>
        /// <param name="lambda">Lambda to be treated as expression.</param>
        /// <returns>Expression from lambda.</returns>
        public static Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> Expression<T1, T2, T3, T4, T5, T6, T7, TResult>(
            T1 argument1Example,
            T2 argument2Example,
            T3 argument3Example,
            T4 argument4Example,
            T5 argument5Example,
            T6 argument6Example,
            T7 argument7Example,
            Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as expression.
        /// </summary>
        /// <typeparam name="TResult">Expression result type.</typeparam>
        /// <typeparam name="T1">Expression argument #1 type.</typeparam>
        /// <typeparam name="T2">Expression argument #2 type.</typeparam>
        /// <typeparam name="T3">Expression argument #3 type.</typeparam>
        /// <typeparam name="T4">Expression argument #4 type.</typeparam>
        /// <typeparam name="T5">Expression argument #5 type.</typeparam>
        /// <typeparam name="T6">Expression argument #6 type.</typeparam>
        /// <typeparam name="T7">Expression argument #7 type.</typeparam>
        /// <typeparam name="T8">Expression argument #8 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="argument2Example">Any argument with compile-time type of argument #2.</param>
        /// <param name="argument3Example">Any argument with compile-time type of argument #3.</param>
        /// <param name="argument4Example">Any argument with compile-time type of argument #4.</param>
        /// <param name="argument5Example">Any argument with compile-time type of argument #5.</param>
        /// <param name="argument6Example">Any argument with compile-time type of argument #6.</param>
        /// <param name="argument7Example">Any argument with compile-time type of argument #7.</param>
        /// <param name="argument8Example">Any argument with compile-time type of argument #8.</param>
        /// <param name="lambda">Lambda to be treated as expression.</param>
        /// <returns>Expression from lambda.</returns>
        public
                static
                Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>>
                Expression<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            T1 argument1Example,
            T2 argument2Example,
            T3 argument3Example,
            T4 argument4Example,
            T5 argument5Example,
            T6 argument6Example,
            T7 argument7Example,
            T8 argument8Example,
            Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as expression.
        /// </summary>
        /// <typeparam name="TResult">Expression result type.</typeparam>
        /// <typeparam name="T1">Expression argument #1 type.</typeparam>
        /// <typeparam name="T2">Expression argument #2 type.</typeparam>
        /// <typeparam name="T3">Expression argument #3 type.</typeparam>
        /// <typeparam name="T4">Expression argument #4 type.</typeparam>
        /// <typeparam name="T5">Expression argument #5 type.</typeparam>
        /// <typeparam name="T6">Expression argument #6 type.</typeparam>
        /// <typeparam name="T7">Expression argument #7 type.</typeparam>
        /// <typeparam name="T8">Expression argument #8 type.</typeparam>
        /// <typeparam name="T9">Expression argument #9 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="argument2Example">Any argument with compile-time type of argument #2.</param>
        /// <param name="argument3Example">Any argument with compile-time type of argument #3.</param>
        /// <param name="argument4Example">Any argument with compile-time type of argument #4.</param>
        /// <param name="argument5Example">Any argument with compile-time type of argument #5.</param>
        /// <param name="argument6Example">Any argument with compile-time type of argument #6.</param>
        /// <param name="argument7Example">Any argument with compile-time type of argument #7.</param>
        /// <param name="argument8Example">Any argument with compile-time type of argument #8.</param>
        /// <param name="argument9Example">Any argument with compile-time type of argument #9.</param>
        /// <param name="lambda">Lambda to be treated as expression.</param>
        /// <returns>Expression from lambda.</returns>
        public
                static
                Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>>
                Expression<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            T1 argument1Example,
            T2 argument2Example,
            T3 argument3Example,
            T4 argument4Example,
            T5 argument5Example,
            T6 argument6Example,
            T7 argument7Example,
            T8 argument8Example,
            T9 argument9Example,
            Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as expression.
        /// </summary>
        /// <typeparam name="TResult">Expression result type.</typeparam>
        /// <typeparam name="T1">Expression argument #1 type.</typeparam>
        /// <typeparam name="T2">Expression argument #2 type.</typeparam>
        /// <typeparam name="T3">Expression argument #3 type.</typeparam>
        /// <typeparam name="T4">Expression argument #4 type.</typeparam>
        /// <typeparam name="T5">Expression argument #5 type.</typeparam>
        /// <typeparam name="T6">Expression argument #6 type.</typeparam>
        /// <typeparam name="T7">Expression argument #7 type.</typeparam>
        /// <typeparam name="T8">Expression argument #8 type.</typeparam>
        /// <typeparam name="T9">Expression argument #9 type.</typeparam>
        /// <typeparam name="T10">Expression argument #10 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="argument2Example">Any argument with compile-time type of argument #2.</param>
        /// <param name="argument3Example">Any argument with compile-time type of argument #3.</param>
        /// <param name="argument4Example">Any argument with compile-time type of argument #4.</param>
        /// <param name="argument5Example">Any argument with compile-time type of argument #5.</param>
        /// <param name="argument6Example">Any argument with compile-time type of argument #6.</param>
        /// <param name="argument7Example">Any argument with compile-time type of argument #7.</param>
        /// <param name="argument8Example">Any argument with compile-time type of argument #8.</param>
        /// <param name="argument9Example">Any argument with compile-time type of argument #9.</param>
        /// <param name="argument10Example">Any argument with compile-time type of argument #10.</param>
        /// <param name="lambda">Lambda to be treated as expression.</param>
        /// <returns>Expression from lambda.</returns>
        public
                static
                Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>>
                Expression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            T1 argument1Example,
            T2 argument2Example,
            T3 argument3Example,
            T4 argument4Example,
            T5 argument5Example,
            T6 argument6Example,
            T7 argument7Example,
            T8 argument8Example,
            T9 argument9Example,
            T10 argument10Example,
            Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as expression.
        /// </summary>
        /// <typeparam name="TResult">Expression result type.</typeparam>
        /// <typeparam name="T1">Expression argument #1 type.</typeparam>
        /// <typeparam name="T2">Expression argument #2 type.</typeparam>
        /// <typeparam name="T3">Expression argument #3 type.</typeparam>
        /// <typeparam name="T4">Expression argument #4 type.</typeparam>
        /// <typeparam name="T5">Expression argument #5 type.</typeparam>
        /// <typeparam name="T6">Expression argument #6 type.</typeparam>
        /// <typeparam name="T7">Expression argument #7 type.</typeparam>
        /// <typeparam name="T8">Expression argument #8 type.</typeparam>
        /// <typeparam name="T9">Expression argument #9 type.</typeparam>
        /// <typeparam name="T10">Expression argument #10 type.</typeparam>
        /// <typeparam name="T11">Expression argument #11 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="argument2Example">Any argument with compile-time type of argument #2.</param>
        /// <param name="argument3Example">Any argument with compile-time type of argument #3.</param>
        /// <param name="argument4Example">Any argument with compile-time type of argument #4.</param>
        /// <param name="argument5Example">Any argument with compile-time type of argument #5.</param>
        /// <param name="argument6Example">Any argument with compile-time type of argument #6.</param>
        /// <param name="argument7Example">Any argument with compile-time type of argument #7.</param>
        /// <param name="argument8Example">Any argument with compile-time type of argument #8.</param>
        /// <param name="argument9Example">Any argument with compile-time type of argument #9.</param>
        /// <param name="argument10Example">Any argument with compile-time type of argument #10.</param>
        /// <param name="argument11Example">Any argument with compile-time type of argument #11.</param>
        /// <param name="lambda">Lambda to be treated as expression.</param>
        /// <returns>Expression from lambda.</returns>
        public
                static
                Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>>
                Expression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            T1 argument1Example,
            T2 argument2Example,
            T3 argument3Example,
            T4 argument4Example,
            T5 argument5Example,
            T6 argument6Example,
            T7 argument7Example,
            T8 argument8Example,
            T9 argument9Example,
            T10 argument10Example,
            T11 argument11Example,
            Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as expression.
        /// </summary>
        /// <typeparam name="TResult">Expression result type.</typeparam>
        /// <typeparam name="T1">Expression argument #1 type.</typeparam>
        /// <typeparam name="T2">Expression argument #2 type.</typeparam>
        /// <typeparam name="T3">Expression argument #3 type.</typeparam>
        /// <typeparam name="T4">Expression argument #4 type.</typeparam>
        /// <typeparam name="T5">Expression argument #5 type.</typeparam>
        /// <typeparam name="T6">Expression argument #6 type.</typeparam>
        /// <typeparam name="T7">Expression argument #7 type.</typeparam>
        /// <typeparam name="T8">Expression argument #8 type.</typeparam>
        /// <typeparam name="T9">Expression argument #9 type.</typeparam>
        /// <typeparam name="T10">Expression argument #10 type.</typeparam>
        /// <typeparam name="T11">Expression argument #11 type.</typeparam>
        /// <typeparam name="T12">Expression argument #12 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="argument2Example">Any argument with compile-time type of argument #2.</param>
        /// <param name="argument3Example">Any argument with compile-time type of argument #3.</param>
        /// <param name="argument4Example">Any argument with compile-time type of argument #4.</param>
        /// <param name="argument5Example">Any argument with compile-time type of argument #5.</param>
        /// <param name="argument6Example">Any argument with compile-time type of argument #6.</param>
        /// <param name="argument7Example">Any argument with compile-time type of argument #7.</param>
        /// <param name="argument8Example">Any argument with compile-time type of argument #8.</param>
        /// <param name="argument9Example">Any argument with compile-time type of argument #9.</param>
        /// <param name="argument10Example">Any argument with compile-time type of argument #10.</param>
        /// <param name="argument11Example">Any argument with compile-time type of argument #11.</param>
        /// <param name="argument12Example">Any argument with compile-time type of argument #12.</param>
        /// <param name="lambda">Lambda to be treated as expression.</param>
        /// <returns>Expression from lambda.</returns>
        public
                static
                Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>>
                Expression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            T1 argument1Example,
            T2 argument2Example,
            T3 argument3Example,
            T4 argument4Example,
            T5 argument5Example,
            T6 argument6Example,
            T7 argument7Example,
            T8 argument8Example,
            T9 argument9Example,
            T10 argument10Example,
            T11 argument11Example,
            T12 argument12Example,
            Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as expression.
        /// </summary>
        /// <typeparam name="TResult">Expression result type.</typeparam>
        /// <typeparam name="T1">Expression argument #1 type.</typeparam>
        /// <typeparam name="T2">Expression argument #2 type.</typeparam>
        /// <typeparam name="T3">Expression argument #3 type.</typeparam>
        /// <typeparam name="T4">Expression argument #4 type.</typeparam>
        /// <typeparam name="T5">Expression argument #5 type.</typeparam>
        /// <typeparam name="T6">Expression argument #6 type.</typeparam>
        /// <typeparam name="T7">Expression argument #7 type.</typeparam>
        /// <typeparam name="T8">Expression argument #8 type.</typeparam>
        /// <typeparam name="T9">Expression argument #9 type.</typeparam>
        /// <typeparam name="T10">Expression argument #10 type.</typeparam>
        /// <typeparam name="T11">Expression argument #11 type.</typeparam>
        /// <typeparam name="T12">Expression argument #12 type.</typeparam>
        /// <typeparam name="T13">Expression argument #13 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="argument2Example">Any argument with compile-time type of argument #2.</param>
        /// <param name="argument3Example">Any argument with compile-time type of argument #3.</param>
        /// <param name="argument4Example">Any argument with compile-time type of argument #4.</param>
        /// <param name="argument5Example">Any argument with compile-time type of argument #5.</param>
        /// <param name="argument6Example">Any argument with compile-time type of argument #6.</param>
        /// <param name="argument7Example">Any argument with compile-time type of argument #7.</param>
        /// <param name="argument8Example">Any argument with compile-time type of argument #8.</param>
        /// <param name="argument9Example">Any argument with compile-time type of argument #9.</param>
        /// <param name="argument10Example">Any argument with compile-time type of argument #10.</param>
        /// <param name="argument11Example">Any argument with compile-time type of argument #11.</param>
        /// <param name="argument12Example">Any argument with compile-time type of argument #12.</param>
        /// <param name="argument13Example">Any argument with compile-time type of argument #13.</param>
        /// <param name="lambda">Lambda to be treated as expression.</param>
        /// <returns>Expression from lambda.</returns>
        public
                static
                Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>>
                Expression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            T1 argument1Example,
            T2 argument2Example,
            T3 argument3Example,
            T4 argument4Example,
            T5 argument5Example,
            T6 argument6Example,
            T7 argument7Example,
            T8 argument8Example,
            T9 argument9Example,
            T10 argument10Example,
            T11 argument11Example,
            T12 argument12Example,
            T13 argument13Example,
            Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as expression.
        /// </summary>
        /// <typeparam name="TResult">Expression result type.</typeparam>
        /// <typeparam name="T1">Expression argument #1 type.</typeparam>
        /// <typeparam name="T2">Expression argument #2 type.</typeparam>
        /// <typeparam name="T3">Expression argument #3 type.</typeparam>
        /// <typeparam name="T4">Expression argument #4 type.</typeparam>
        /// <typeparam name="T5">Expression argument #5 type.</typeparam>
        /// <typeparam name="T6">Expression argument #6 type.</typeparam>
        /// <typeparam name="T7">Expression argument #7 type.</typeparam>
        /// <typeparam name="T8">Expression argument #8 type.</typeparam>
        /// <typeparam name="T9">Expression argument #9 type.</typeparam>
        /// <typeparam name="T10">Expression argument #10 type.</typeparam>
        /// <typeparam name="T11">Expression argument #11 type.</typeparam>
        /// <typeparam name="T12">Expression argument #12 type.</typeparam>
        /// <typeparam name="T13">Expression argument #13 type.</typeparam>
        /// <typeparam name="T14">Expression argument #14 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="argument2Example">Any argument with compile-time type of argument #2.</param>
        /// <param name="argument3Example">Any argument with compile-time type of argument #3.</param>
        /// <param name="argument4Example">Any argument with compile-time type of argument #4.</param>
        /// <param name="argument5Example">Any argument with compile-time type of argument #5.</param>
        /// <param name="argument6Example">Any argument with compile-time type of argument #6.</param>
        /// <param name="argument7Example">Any argument with compile-time type of argument #7.</param>
        /// <param name="argument8Example">Any argument with compile-time type of argument #8.</param>
        /// <param name="argument9Example">Any argument with compile-time type of argument #9.</param>
        /// <param name="argument10Example">Any argument with compile-time type of argument #10.</param>
        /// <param name="argument11Example">Any argument with compile-time type of argument #11.</param>
        /// <param name="argument12Example">Any argument with compile-time type of argument #12.</param>
        /// <param name="argument13Example">Any argument with compile-time type of argument #13.</param>
        /// <param name="argument14Example">Any argument with compile-time type of argument #14.</param>
        /// <param name="lambda">Lambda to be treated as expression.</param>
        /// <returns>Expression from lambda.</returns>
        public
                static
                Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>>
                Expression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            T1 argument1Example,
            T2 argument2Example,
            T3 argument3Example,
            T4 argument4Example,
            T5 argument5Example,
            T6 argument6Example,
            T7 argument7Example,
            T8 argument8Example,
            T9 argument9Example,
            T10 argument10Example,
            T11 argument11Example,
            T12 argument12Example,
            T13 argument13Example,
            T14 argument14Example,
            Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as expression.
        /// </summary>
        /// <typeparam name="TResult">Expression result type.</typeparam>
        /// <typeparam name="T1">Expression argument #1 type.</typeparam>
        /// <typeparam name="T2">Expression argument #2 type.</typeparam>
        /// <typeparam name="T3">Expression argument #3 type.</typeparam>
        /// <typeparam name="T4">Expression argument #4 type.</typeparam>
        /// <typeparam name="T5">Expression argument #5 type.</typeparam>
        /// <typeparam name="T6">Expression argument #6 type.</typeparam>
        /// <typeparam name="T7">Expression argument #7 type.</typeparam>
        /// <typeparam name="T8">Expression argument #8 type.</typeparam>
        /// <typeparam name="T9">Expression argument #9 type.</typeparam>
        /// <typeparam name="T10">Expression argument #10 type.</typeparam>
        /// <typeparam name="T11">Expression argument #11 type.</typeparam>
        /// <typeparam name="T12">Expression argument #12 type.</typeparam>
        /// <typeparam name="T13">Expression argument #13 type.</typeparam>
        /// <typeparam name="T14">Expression argument #14 type.</typeparam>
        /// <typeparam name="T15">Expression argument #15 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="argument2Example">Any argument with compile-time type of argument #2.</param>
        /// <param name="argument3Example">Any argument with compile-time type of argument #3.</param>
        /// <param name="argument4Example">Any argument with compile-time type of argument #4.</param>
        /// <param name="argument5Example">Any argument with compile-time type of argument #5.</param>
        /// <param name="argument6Example">Any argument with compile-time type of argument #6.</param>
        /// <param name="argument7Example">Any argument with compile-time type of argument #7.</param>
        /// <param name="argument8Example">Any argument with compile-time type of argument #8.</param>
        /// <param name="argument9Example">Any argument with compile-time type of argument #9.</param>
        /// <param name="argument10Example">Any argument with compile-time type of argument #10.</param>
        /// <param name="argument11Example">Any argument with compile-time type of argument #11.</param>
        /// <param name="argument12Example">Any argument with compile-time type of argument #12.</param>
        /// <param name="argument13Example">Any argument with compile-time type of argument #13.</param>
        /// <param name="argument14Example">Any argument with compile-time type of argument #14.</param>
        /// <param name="argument15Example">Any argument with compile-time type of argument #15.</param>
        /// <param name="lambda">Lambda to be treated as expression.</param>
        /// <returns>Expression from lambda.</returns>
        public
                static
                Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>>
                Expression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            T1 argument1Example,
            T2 argument2Example,
            T3 argument3Example,
            T4 argument4Example,
            T5 argument5Example,
            T6 argument6Example,
            T7 argument7Example,
            T8 argument8Example,
            T9 argument9Example,
            T10 argument10Example,
            T11 argument11Example,
            T12 argument12Example,
            T13 argument13Example,
            T14 argument14Example,
            T15 argument15Example,
            Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as expression.
        /// </summary>
        /// <typeparam name="TResult">Expression result type.</typeparam>
        /// <typeparam name="T1">Expression argument #1 type.</typeparam>
        /// <typeparam name="T2">Expression argument #2 type.</typeparam>
        /// <typeparam name="T3">Expression argument #3 type.</typeparam>
        /// <typeparam name="T4">Expression argument #4 type.</typeparam>
        /// <typeparam name="T5">Expression argument #5 type.</typeparam>
        /// <typeparam name="T6">Expression argument #6 type.</typeparam>
        /// <typeparam name="T7">Expression argument #7 type.</typeparam>
        /// <typeparam name="T8">Expression argument #8 type.</typeparam>
        /// <typeparam name="T9">Expression argument #9 type.</typeparam>
        /// <typeparam name="T10">Expression argument #10 type.</typeparam>
        /// <typeparam name="T11">Expression argument #11 type.</typeparam>
        /// <typeparam name="T12">Expression argument #12 type.</typeparam>
        /// <typeparam name="T13">Expression argument #13 type.</typeparam>
        /// <typeparam name="T14">Expression argument #14 type.</typeparam>
        /// <typeparam name="T15">Expression argument #15 type.</typeparam>
        /// <typeparam name="T16">Expression argument #16 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="argument2Example">Any argument with compile-time type of argument #2.</param>
        /// <param name="argument3Example">Any argument with compile-time type of argument #3.</param>
        /// <param name="argument4Example">Any argument with compile-time type of argument #4.</param>
        /// <param name="argument5Example">Any argument with compile-time type of argument #5.</param>
        /// <param name="argument6Example">Any argument with compile-time type of argument #6.</param>
        /// <param name="argument7Example">Any argument with compile-time type of argument #7.</param>
        /// <param name="argument8Example">Any argument with compile-time type of argument #8.</param>
        /// <param name="argument9Example">Any argument with compile-time type of argument #9.</param>
        /// <param name="argument10Example">Any argument with compile-time type of argument #10.</param>
        /// <param name="argument11Example">Any argument with compile-time type of argument #11.</param>
        /// <param name="argument12Example">Any argument with compile-time type of argument #12.</param>
        /// <param name="argument13Example">Any argument with compile-time type of argument #13.</param>
        /// <param name="argument14Example">Any argument with compile-time type of argument #14.</param>
        /// <param name="argument15Example">Any argument with compile-time type of argument #15.</param>
        /// <param name="argument16Example">Any argument with compile-time type of argument #16.</param>
        /// <param name="lambda">Lambda to be treated as expression.</param>
        /// <returns>Expression from lambda.</returns>
        public
                static
                Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>>
                Expression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            T1 argument1Example,
            T2 argument2Example,
            T3 argument3Example,
            T4 argument4Example,
            T5 argument5Example,
            T6 argument6Example,
            T7 argument7Example,
            T8 argument8Example,
            T9 argument9Example,
            T10 argument10Example,
            T11 argument11Example,
            T12 argument12Example,
            T13 argument13Example,
            T14 argument14Example,
            T15 argument15Example,
            T16 argument16Example,
            Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as delegate.
        /// </summary>
        /// <typeparam name="TResult">Delegate result type.</typeparam>
        /// <param name="lambda">Lambda to be treated as gelegate.</param>
        /// <returns>Delegate from lambda.</returns>
        public static Func<TResult> Func<TResult>(Func<TResult> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as delegate.
        /// </summary>
        /// <typeparam name="TResult">Delegate result type.</typeparam>
        /// <typeparam name="T1">Delegate argument #1 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="lambda">Lambda to be treated as gelegate.</param>
        /// <returns>Delegate from lambda.</returns>
        public static Func<T1, TResult> Func<T1, TResult>(
            T1 argument1Example,
            Func<T1, TResult> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as delegate.
        /// </summary>
        /// <typeparam name="TResult">Delegate result type.</typeparam>
        /// <typeparam name="T1">Delegate argument #1 type.</typeparam>
        /// <typeparam name="T2">Delegate argument #2 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="argument2Example">Any argument with compile-time type of argument #2.</param>
        /// <param name="lambda">Lambda to be treated as gelegate.</param>
        /// <returns>Delegate from lambda.</returns>
        public static Func<T1, T2, TResult> Func<T1, T2, TResult>(
            T1 argument1Example,
            T2 argument2Example,
            Func<T1, T2, TResult> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as delegate.
        /// </summary>
        /// <typeparam name="TResult">Delegate result type.</typeparam>
        /// <typeparam name="T1">Delegate argument #1 type.</typeparam>
        /// <typeparam name="T2">Delegate argument #2 type.</typeparam>
        /// <typeparam name="T3">Delegate argument #3 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="argument2Example">Any argument with compile-time type of argument #2.</param>
        /// <param name="argument3Example">Any argument with compile-time type of argument #3.</param>
        /// <param name="lambda">Lambda to be treated as gelegate.</param>
        /// <returns>Delegate from lambda.</returns>
        public static Func<T1, T2, T3, TResult> Func<T1, T2, T3, TResult>(
            T1 argument1Example,
            T2 argument2Example,
            T3 argument3Example,
            Func<T1, T2, T3, TResult> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as delegate.
        /// </summary>
        /// <typeparam name="TResult">Delegate result type.</typeparam>
        /// <typeparam name="T1">Delegate argument #1 type.</typeparam>
        /// <typeparam name="T2">Delegate argument #2 type.</typeparam>
        /// <typeparam name="T3">Delegate argument #3 type.</typeparam>
        /// <typeparam name="T4">Delegate argument #4 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="argument2Example">Any argument with compile-time type of argument #2.</param>
        /// <param name="argument3Example">Any argument with compile-time type of argument #3.</param>
        /// <param name="argument4Example">Any argument with compile-time type of argument #4.</param>
        /// <param name="lambda">Lambda to be treated as gelegate.</param>
        /// <returns>Delegate from lambda.</returns>
        public static Func<T1, T2, T3, T4, TResult> Func<T1, T2, T3, T4, TResult>(
            T1 argument1Example,
            T2 argument2Example,
            T3 argument3Example,
            T4 argument4Example,
            Func<T1, T2, T3, T4, TResult> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as delegate.
        /// </summary>
        /// <typeparam name="TResult">Delegate result type.</typeparam>
        /// <typeparam name="T1">Delegate argument #1 type.</typeparam>
        /// <typeparam name="T2">Delegate argument #2 type.</typeparam>
        /// <typeparam name="T3">Delegate argument #3 type.</typeparam>
        /// <typeparam name="T4">Delegate argument #4 type.</typeparam>
        /// <typeparam name="T5">Delegate argument #5 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="argument2Example">Any argument with compile-time type of argument #2.</param>
        /// <param name="argument3Example">Any argument with compile-time type of argument #3.</param>
        /// <param name="argument4Example">Any argument with compile-time type of argument #4.</param>
        /// <param name="argument5Example">Any argument with compile-time type of argument #5.</param>
        /// <param name="lambda">Lambda to be treated as gelegate.</param>
        /// <returns>Delegate from lambda.</returns>
        public static Func<T1, T2, T3, T4, T5, TResult> Func<T1, T2, T3, T4, T5, TResult>(
            T1 argument1Example,
            T2 argument2Example,
            T3 argument3Example,
            T4 argument4Example,
            T5 argument5Example,
            Func<T1, T2, T3, T4, T5, TResult> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as delegate.
        /// </summary>
        /// <typeparam name="TResult">Delegate result type.</typeparam>
        /// <typeparam name="T1">Delegate argument #1 type.</typeparam>
        /// <typeparam name="T2">Delegate argument #2 type.</typeparam>
        /// <typeparam name="T3">Delegate argument #3 type.</typeparam>
        /// <typeparam name="T4">Delegate argument #4 type.</typeparam>
        /// <typeparam name="T5">Delegate argument #5 type.</typeparam>
        /// <typeparam name="T6">Delegate argument #6 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="argument2Example">Any argument with compile-time type of argument #2.</param>
        /// <param name="argument3Example">Any argument with compile-time type of argument #3.</param>
        /// <param name="argument4Example">Any argument with compile-time type of argument #4.</param>
        /// <param name="argument5Example">Any argument with compile-time type of argument #5.</param>
        /// <param name="argument6Example">Any argument with compile-time type of argument #6.</param>
        /// <param name="lambda">Lambda to be treated as gelegate.</param>
        /// <returns>Delegate from lambda.</returns>
        public static Func<T1, T2, T3, T4, T5, T6, TResult> Func<T1, T2, T3, T4, T5, T6, TResult>(
            T1 argument1Example,
            T2 argument2Example,
            T3 argument3Example,
            T4 argument4Example,
            T5 argument5Example,
            T6 argument6Example,
            Func<T1, T2, T3, T4, T5, T6, TResult> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as delegate.
        /// </summary>
        /// <typeparam name="TResult">Delegate result type.</typeparam>
        /// <typeparam name="T1">Delegate argument #1 type.</typeparam>
        /// <typeparam name="T2">Delegate argument #2 type.</typeparam>
        /// <typeparam name="T3">Delegate argument #3 type.</typeparam>
        /// <typeparam name="T4">Delegate argument #4 type.</typeparam>
        /// <typeparam name="T5">Delegate argument #5 type.</typeparam>
        /// <typeparam name="T6">Delegate argument #6 type.</typeparam>
        /// <typeparam name="T7">Delegate argument #7 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="argument2Example">Any argument with compile-time type of argument #2.</param>
        /// <param name="argument3Example">Any argument with compile-time type of argument #3.</param>
        /// <param name="argument4Example">Any argument with compile-time type of argument #4.</param>
        /// <param name="argument5Example">Any argument with compile-time type of argument #5.</param>
        /// <param name="argument6Example">Any argument with compile-time type of argument #6.</param>
        /// <param name="argument7Example">Any argument with compile-time type of argument #7.</param>
        /// <param name="lambda">Lambda to be treated as gelegate.</param>
        /// <returns>Delegate from lambda.</returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, TResult> Func<T1, T2, T3, T4, T5, T6, T7, TResult>(
            T1 argument1Example,
            T2 argument2Example,
            T3 argument3Example,
            T4 argument4Example,
            T5 argument5Example,
            T6 argument6Example,
            T7 argument7Example,
            Func<T1, T2, T3, T4, T5, T6, T7, TResult> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as delegate.
        /// </summary>
        /// <typeparam name="TResult">Delegate result type.</typeparam>
        /// <typeparam name="T1">Delegate argument #1 type.</typeparam>
        /// <typeparam name="T2">Delegate argument #2 type.</typeparam>
        /// <typeparam name="T3">Delegate argument #3 type.</typeparam>
        /// <typeparam name="T4">Delegate argument #4 type.</typeparam>
        /// <typeparam name="T5">Delegate argument #5 type.</typeparam>
        /// <typeparam name="T6">Delegate argument #6 type.</typeparam>
        /// <typeparam name="T7">Delegate argument #7 type.</typeparam>
        /// <typeparam name="T8">Delegate argument #8 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="argument2Example">Any argument with compile-time type of argument #2.</param>
        /// <param name="argument3Example">Any argument with compile-time type of argument #3.</param>
        /// <param name="argument4Example">Any argument with compile-time type of argument #4.</param>
        /// <param name="argument5Example">Any argument with compile-time type of argument #5.</param>
        /// <param name="argument6Example">Any argument with compile-time type of argument #6.</param>
        /// <param name="argument7Example">Any argument with compile-time type of argument #7.</param>
        /// <param name="argument8Example">Any argument with compile-time type of argument #8.</param>
        /// <param name="lambda">Lambda to be treated as gelegate.</param>
        /// <returns>Delegate from lambda.</returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            T1 argument1Example,
            T2 argument2Example,
            T3 argument3Example,
            T4 argument4Example,
            T5 argument5Example,
            T6 argument6Example,
            T7 argument7Example,
            T8 argument8Example,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as delegate.
        /// </summary>
        /// <typeparam name="TResult">Delegate result type.</typeparam>
        /// <typeparam name="T1">Delegate argument #1 type.</typeparam>
        /// <typeparam name="T2">Delegate argument #2 type.</typeparam>
        /// <typeparam name="T3">Delegate argument #3 type.</typeparam>
        /// <typeparam name="T4">Delegate argument #4 type.</typeparam>
        /// <typeparam name="T5">Delegate argument #5 type.</typeparam>
        /// <typeparam name="T6">Delegate argument #6 type.</typeparam>
        /// <typeparam name="T7">Delegate argument #7 type.</typeparam>
        /// <typeparam name="T8">Delegate argument #8 type.</typeparam>
        /// <typeparam name="T9">Delegate argument #9 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="argument2Example">Any argument with compile-time type of argument #2.</param>
        /// <param name="argument3Example">Any argument with compile-time type of argument #3.</param>
        /// <param name="argument4Example">Any argument with compile-time type of argument #4.</param>
        /// <param name="argument5Example">Any argument with compile-time type of argument #5.</param>
        /// <param name="argument6Example">Any argument with compile-time type of argument #6.</param>
        /// <param name="argument7Example">Any argument with compile-time type of argument #7.</param>
        /// <param name="argument8Example">Any argument with compile-time type of argument #8.</param>
        /// <param name="argument9Example">Any argument with compile-time type of argument #9.</param>
        /// <param name="lambda">Lambda to be treated as gelegate.</param>
        /// <returns>Delegate from lambda.</returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            T1 argument1Example,
            T2 argument2Example,
            T3 argument3Example,
            T4 argument4Example,
            T5 argument5Example,
            T6 argument6Example,
            T7 argument7Example,
            T8 argument8Example,
            T9 argument9Example,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as delegate.
        /// </summary>
        /// <typeparam name="TResult">Delegate result type.</typeparam>
        /// <typeparam name="T1">Delegate argument #1 type.</typeparam>
        /// <typeparam name="T2">Delegate argument #2 type.</typeparam>
        /// <typeparam name="T3">Delegate argument #3 type.</typeparam>
        /// <typeparam name="T4">Delegate argument #4 type.</typeparam>
        /// <typeparam name="T5">Delegate argument #5 type.</typeparam>
        /// <typeparam name="T6">Delegate argument #6 type.</typeparam>
        /// <typeparam name="T7">Delegate argument #7 type.</typeparam>
        /// <typeparam name="T8">Delegate argument #8 type.</typeparam>
        /// <typeparam name="T9">Delegate argument #9 type.</typeparam>
        /// <typeparam name="T10">Delegate argument #10 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="argument2Example">Any argument with compile-time type of argument #2.</param>
        /// <param name="argument3Example">Any argument with compile-time type of argument #3.</param>
        /// <param name="argument4Example">Any argument with compile-time type of argument #4.</param>
        /// <param name="argument5Example">Any argument with compile-time type of argument #5.</param>
        /// <param name="argument6Example">Any argument with compile-time type of argument #6.</param>
        /// <param name="argument7Example">Any argument with compile-time type of argument #7.</param>
        /// <param name="argument8Example">Any argument with compile-time type of argument #8.</param>
        /// <param name="argument9Example">Any argument with compile-time type of argument #9.</param>
        /// <param name="argument10Example">Any argument with compile-time type of argument #10.</param>
        /// <param name="lambda">Lambda to be treated as gelegate.</param>
        /// <returns>Delegate from lambda.</returns>
        public
                static
                Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>
                Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            T1 argument1Example,
            T2 argument2Example,
            T3 argument3Example,
            T4 argument4Example,
            T5 argument5Example,
            T6 argument6Example,
            T7 argument7Example,
            T8 argument8Example,
            T9 argument9Example,
            T10 argument10Example,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as delegate.
        /// </summary>
        /// <typeparam name="TResult">Delegate result type.</typeparam>
        /// <typeparam name="T1">Delegate argument #1 type.</typeparam>
        /// <typeparam name="T2">Delegate argument #2 type.</typeparam>
        /// <typeparam name="T3">Delegate argument #3 type.</typeparam>
        /// <typeparam name="T4">Delegate argument #4 type.</typeparam>
        /// <typeparam name="T5">Delegate argument #5 type.</typeparam>
        /// <typeparam name="T6">Delegate argument #6 type.</typeparam>
        /// <typeparam name="T7">Delegate argument #7 type.</typeparam>
        /// <typeparam name="T8">Delegate argument #8 type.</typeparam>
        /// <typeparam name="T9">Delegate argument #9 type.</typeparam>
        /// <typeparam name="T10">Delegate argument #10 type.</typeparam>
        /// <typeparam name="T11">Delegate argument #11 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="argument2Example">Any argument with compile-time type of argument #2.</param>
        /// <param name="argument3Example">Any argument with compile-time type of argument #3.</param>
        /// <param name="argument4Example">Any argument with compile-time type of argument #4.</param>
        /// <param name="argument5Example">Any argument with compile-time type of argument #5.</param>
        /// <param name="argument6Example">Any argument with compile-time type of argument #6.</param>
        /// <param name="argument7Example">Any argument with compile-time type of argument #7.</param>
        /// <param name="argument8Example">Any argument with compile-time type of argument #8.</param>
        /// <param name="argument9Example">Any argument with compile-time type of argument #9.</param>
        /// <param name="argument10Example">Any argument with compile-time type of argument #10.</param>
        /// <param name="argument11Example">Any argument with compile-time type of argument #11.</param>
        /// <param name="lambda">Lambda to be treated as gelegate.</param>
        /// <returns>Delegate from lambda.</returns>
        public
                static
                Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>
                Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            T1 argument1Example,
            T2 argument2Example,
            T3 argument3Example,
            T4 argument4Example,
            T5 argument5Example,
            T6 argument6Example,
            T7 argument7Example,
            T8 argument8Example,
            T9 argument9Example,
            T10 argument10Example,
            T11 argument11Example,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as delegate.
        /// </summary>
        /// <typeparam name="TResult">Delegate result type.</typeparam>
        /// <typeparam name="T1">Delegate argument #1 type.</typeparam>
        /// <typeparam name="T2">Delegate argument #2 type.</typeparam>
        /// <typeparam name="T3">Delegate argument #3 type.</typeparam>
        /// <typeparam name="T4">Delegate argument #4 type.</typeparam>
        /// <typeparam name="T5">Delegate argument #5 type.</typeparam>
        /// <typeparam name="T6">Delegate argument #6 type.</typeparam>
        /// <typeparam name="T7">Delegate argument #7 type.</typeparam>
        /// <typeparam name="T8">Delegate argument #8 type.</typeparam>
        /// <typeparam name="T9">Delegate argument #9 type.</typeparam>
        /// <typeparam name="T10">Delegate argument #10 type.</typeparam>
        /// <typeparam name="T11">Delegate argument #11 type.</typeparam>
        /// <typeparam name="T12">Delegate argument #12 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="argument2Example">Any argument with compile-time type of argument #2.</param>
        /// <param name="argument3Example">Any argument with compile-time type of argument #3.</param>
        /// <param name="argument4Example">Any argument with compile-time type of argument #4.</param>
        /// <param name="argument5Example">Any argument with compile-time type of argument #5.</param>
        /// <param name="argument6Example">Any argument with compile-time type of argument #6.</param>
        /// <param name="argument7Example">Any argument with compile-time type of argument #7.</param>
        /// <param name="argument8Example">Any argument with compile-time type of argument #8.</param>
        /// <param name="argument9Example">Any argument with compile-time type of argument #9.</param>
        /// <param name="argument10Example">Any argument with compile-time type of argument #10.</param>
        /// <param name="argument11Example">Any argument with compile-time type of argument #11.</param>
        /// <param name="argument12Example">Any argument with compile-time type of argument #12.</param>
        /// <param name="lambda">Lambda to be treated as gelegate.</param>
        /// <returns>Delegate from lambda.</returns>
        public
                static
                Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>
                Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            T1 argument1Example,
            T2 argument2Example,
            T3 argument3Example,
            T4 argument4Example,
            T5 argument5Example,
            T6 argument6Example,
            T7 argument7Example,
            T8 argument8Example,
            T9 argument9Example,
            T10 argument10Example,
            T11 argument11Example,
            T12 argument12Example,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as delegate.
        /// </summary>
        /// <typeparam name="TResult">Delegate result type.</typeparam>
        /// <typeparam name="T1">Delegate argument #1 type.</typeparam>
        /// <typeparam name="T2">Delegate argument #2 type.</typeparam>
        /// <typeparam name="T3">Delegate argument #3 type.</typeparam>
        /// <typeparam name="T4">Delegate argument #4 type.</typeparam>
        /// <typeparam name="T5">Delegate argument #5 type.</typeparam>
        /// <typeparam name="T6">Delegate argument #6 type.</typeparam>
        /// <typeparam name="T7">Delegate argument #7 type.</typeparam>
        /// <typeparam name="T8">Delegate argument #8 type.</typeparam>
        /// <typeparam name="T9">Delegate argument #9 type.</typeparam>
        /// <typeparam name="T10">Delegate argument #10 type.</typeparam>
        /// <typeparam name="T11">Delegate argument #11 type.</typeparam>
        /// <typeparam name="T12">Delegate argument #12 type.</typeparam>
        /// <typeparam name="T13">Delegate argument #13 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="argument2Example">Any argument with compile-time type of argument #2.</param>
        /// <param name="argument3Example">Any argument with compile-time type of argument #3.</param>
        /// <param name="argument4Example">Any argument with compile-time type of argument #4.</param>
        /// <param name="argument5Example">Any argument with compile-time type of argument #5.</param>
        /// <param name="argument6Example">Any argument with compile-time type of argument #6.</param>
        /// <param name="argument7Example">Any argument with compile-time type of argument #7.</param>
        /// <param name="argument8Example">Any argument with compile-time type of argument #8.</param>
        /// <param name="argument9Example">Any argument with compile-time type of argument #9.</param>
        /// <param name="argument10Example">Any argument with compile-time type of argument #10.</param>
        /// <param name="argument11Example">Any argument with compile-time type of argument #11.</param>
        /// <param name="argument12Example">Any argument with compile-time type of argument #12.</param>
        /// <param name="argument13Example">Any argument with compile-time type of argument #13.</param>
        /// <param name="lambda">Lambda to be treated as gelegate.</param>
        /// <returns>Delegate from lambda.</returns>
        public
                static
                Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>
                Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            T1 argument1Example,
            T2 argument2Example,
            T3 argument3Example,
            T4 argument4Example,
            T5 argument5Example,
            T6 argument6Example,
            T7 argument7Example,
            T8 argument8Example,
            T9 argument9Example,
            T10 argument10Example,
            T11 argument11Example,
            T12 argument12Example,
            T13 argument13Example,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as delegate.
        /// </summary>
        /// <typeparam name="TResult">Delegate result type.</typeparam>
        /// <typeparam name="T1">Delegate argument #1 type.</typeparam>
        /// <typeparam name="T2">Delegate argument #2 type.</typeparam>
        /// <typeparam name="T3">Delegate argument #3 type.</typeparam>
        /// <typeparam name="T4">Delegate argument #4 type.</typeparam>
        /// <typeparam name="T5">Delegate argument #5 type.</typeparam>
        /// <typeparam name="T6">Delegate argument #6 type.</typeparam>
        /// <typeparam name="T7">Delegate argument #7 type.</typeparam>
        /// <typeparam name="T8">Delegate argument #8 type.</typeparam>
        /// <typeparam name="T9">Delegate argument #9 type.</typeparam>
        /// <typeparam name="T10">Delegate argument #10 type.</typeparam>
        /// <typeparam name="T11">Delegate argument #11 type.</typeparam>
        /// <typeparam name="T12">Delegate argument #12 type.</typeparam>
        /// <typeparam name="T13">Delegate argument #13 type.</typeparam>
        /// <typeparam name="T14">Delegate argument #14 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="argument2Example">Any argument with compile-time type of argument #2.</param>
        /// <param name="argument3Example">Any argument with compile-time type of argument #3.</param>
        /// <param name="argument4Example">Any argument with compile-time type of argument #4.</param>
        /// <param name="argument5Example">Any argument with compile-time type of argument #5.</param>
        /// <param name="argument6Example">Any argument with compile-time type of argument #6.</param>
        /// <param name="argument7Example">Any argument with compile-time type of argument #7.</param>
        /// <param name="argument8Example">Any argument with compile-time type of argument #8.</param>
        /// <param name="argument9Example">Any argument with compile-time type of argument #9.</param>
        /// <param name="argument10Example">Any argument with compile-time type of argument #10.</param>
        /// <param name="argument11Example">Any argument with compile-time type of argument #11.</param>
        /// <param name="argument12Example">Any argument with compile-time type of argument #12.</param>
        /// <param name="argument13Example">Any argument with compile-time type of argument #13.</param>
        /// <param name="argument14Example">Any argument with compile-time type of argument #14.</param>
        /// <param name="lambda">Lambda to be treated as gelegate.</param>
        /// <returns>Delegate from lambda.</returns>
        public
                static
                Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>
                Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            T1 argument1Example,
            T2 argument2Example,
            T3 argument3Example,
            T4 argument4Example,
            T5 argument5Example,
            T6 argument6Example,
            T7 argument7Example,
            T8 argument8Example,
            T9 argument9Example,
            T10 argument10Example,
            T11 argument11Example,
            T12 argument12Example,
            T13 argument13Example,
            T14 argument14Example,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as delegate.
        /// </summary>
        /// <typeparam name="TResult">Delegate result type.</typeparam>
        /// <typeparam name="T1">Delegate argument #1 type.</typeparam>
        /// <typeparam name="T2">Delegate argument #2 type.</typeparam>
        /// <typeparam name="T3">Delegate argument #3 type.</typeparam>
        /// <typeparam name="T4">Delegate argument #4 type.</typeparam>
        /// <typeparam name="T5">Delegate argument #5 type.</typeparam>
        /// <typeparam name="T6">Delegate argument #6 type.</typeparam>
        /// <typeparam name="T7">Delegate argument #7 type.</typeparam>
        /// <typeparam name="T8">Delegate argument #8 type.</typeparam>
        /// <typeparam name="T9">Delegate argument #9 type.</typeparam>
        /// <typeparam name="T10">Delegate argument #10 type.</typeparam>
        /// <typeparam name="T11">Delegate argument #11 type.</typeparam>
        /// <typeparam name="T12">Delegate argument #12 type.</typeparam>
        /// <typeparam name="T13">Delegate argument #13 type.</typeparam>
        /// <typeparam name="T14">Delegate argument #14 type.</typeparam>
        /// <typeparam name="T15">Delegate argument #15 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="argument2Example">Any argument with compile-time type of argument #2.</param>
        /// <param name="argument3Example">Any argument with compile-time type of argument #3.</param>
        /// <param name="argument4Example">Any argument with compile-time type of argument #4.</param>
        /// <param name="argument5Example">Any argument with compile-time type of argument #5.</param>
        /// <param name="argument6Example">Any argument with compile-time type of argument #6.</param>
        /// <param name="argument7Example">Any argument with compile-time type of argument #7.</param>
        /// <param name="argument8Example">Any argument with compile-time type of argument #8.</param>
        /// <param name="argument9Example">Any argument with compile-time type of argument #9.</param>
        /// <param name="argument10Example">Any argument with compile-time type of argument #10.</param>
        /// <param name="argument11Example">Any argument with compile-time type of argument #11.</param>
        /// <param name="argument12Example">Any argument with compile-time type of argument #12.</param>
        /// <param name="argument13Example">Any argument with compile-time type of argument #13.</param>
        /// <param name="argument14Example">Any argument with compile-time type of argument #14.</param>
        /// <param name="argument15Example">Any argument with compile-time type of argument #15.</param>
        /// <param name="lambda">Lambda to be treated as gelegate.</param>
        /// <returns>Delegate from lambda.</returns>
        public
                static
                Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>
                Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            T1 argument1Example,
            T2 argument2Example,
            T3 argument3Example,
            T4 argument4Example,
            T5 argument5Example,
            T6 argument6Example,
            T7 argument7Example,
            T8 argument8Example,
            T9 argument9Example,
            T10 argument10Example,
            T11 argument11Example,
            T12 argument12Example,
            T13 argument13Example,
            T14 argument14Example,
            T15 argument15Example,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }

        /// <summary>
        /// Returns lambda as delegate.
        /// </summary>
        /// <typeparam name="TResult">Delegate result type.</typeparam>
        /// <typeparam name="T1">Delegate argument #1 type.</typeparam>
        /// <typeparam name="T2">Delegate argument #2 type.</typeparam>
        /// <typeparam name="T3">Delegate argument #3 type.</typeparam>
        /// <typeparam name="T4">Delegate argument #4 type.</typeparam>
        /// <typeparam name="T5">Delegate argument #5 type.</typeparam>
        /// <typeparam name="T6">Delegate argument #6 type.</typeparam>
        /// <typeparam name="T7">Delegate argument #7 type.</typeparam>
        /// <typeparam name="T8">Delegate argument #8 type.</typeparam>
        /// <typeparam name="T9">Delegate argument #9 type.</typeparam>
        /// <typeparam name="T10">Delegate argument #10 type.</typeparam>
        /// <typeparam name="T11">Delegate argument #11 type.</typeparam>
        /// <typeparam name="T12">Delegate argument #12 type.</typeparam>
        /// <typeparam name="T13">Delegate argument #13 type.</typeparam>
        /// <typeparam name="T14">Delegate argument #14 type.</typeparam>
        /// <typeparam name="T15">Delegate argument #15 type.</typeparam>
        /// <typeparam name="T16">Delegate argument #16 type.</typeparam>
        /// <param name="argument1Example">Any argument with compile-time type of argument #1.</param>
        /// <param name="argument2Example">Any argument with compile-time type of argument #2.</param>
        /// <param name="argument3Example">Any argument with compile-time type of argument #3.</param>
        /// <param name="argument4Example">Any argument with compile-time type of argument #4.</param>
        /// <param name="argument5Example">Any argument with compile-time type of argument #5.</param>
        /// <param name="argument6Example">Any argument with compile-time type of argument #6.</param>
        /// <param name="argument7Example">Any argument with compile-time type of argument #7.</param>
        /// <param name="argument8Example">Any argument with compile-time type of argument #8.</param>
        /// <param name="argument9Example">Any argument with compile-time type of argument #9.</param>
        /// <param name="argument10Example">Any argument with compile-time type of argument #10.</param>
        /// <param name="argument11Example">Any argument with compile-time type of argument #11.</param>
        /// <param name="argument12Example">Any argument with compile-time type of argument #12.</param>
        /// <param name="argument13Example">Any argument with compile-time type of argument #13.</param>
        /// <param name="argument14Example">Any argument with compile-time type of argument #14.</param>
        /// <param name="argument15Example">Any argument with compile-time type of argument #15.</param>
        /// <param name="argument16Example">Any argument with compile-time type of argument #16.</param>
        /// <param name="lambda">Lambda to be treated as gelegate.</param>
        /// <returns>Delegate from lambda.</returns>
        public
                static
                Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>
                Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            T1 argument1Example,
            T2 argument2Example,
            T3 argument3Example,
            T4 argument4Example,
            T5 argument5Example,
            T6 argument6Example,
            T7 argument7Example,
            T8 argument8Example,
            T9 argument9Example,
            T10 argument10Example,
            T11 argument11Example,
            T12 argument12Example,
            T13 argument13Example,
            T14 argument14Example,
            T15 argument15Example,
            T16 argument16Example,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> lambda)
        {
            if (lambda == null)
                throw new ArgumentNullException(nameof(lambda));

            return lambda;
        }
    }
}
