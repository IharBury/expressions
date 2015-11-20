using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace IharBury.Expressions
{
    /// <summary>
    /// Combines boolean expressions.
    /// </summary>
    public static class BooleanExpressions
    {
        /// <summary>
        /// Combines boolean expressions without parameters via AndAlso 
        /// (logical "and" that evaluates the second argument only when the first one is true).
        /// </summary>
        /// <param name="expressions">Boolean expressions without parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<bool>> CombineViaAndAlso(IEnumerable<Expression<Func<bool>>> expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<bool>>)Combine(
#if NET35 || NET35_CLIENT || NET37_CF
                expressions.Cast<LambdaExpression>(),
#else
                expressions, 
#endif
                Expression.AndAlso);
        }

        /// <summary>
        /// Combines boolean expressions with same parameters via AndAlso 
        /// (logical "and" that evaluates the second argument only when the first one is true).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, bool>> CombineViaAndAlso<T1>(
            IEnumerable<Expression<Func<T1, bool>>> expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, bool>>)Combine(
#if NET35 || NET35_CLIENT || NET37_CF
                expressions.Cast<LambdaExpression>(),
#else
                expressions, 
#endif
                Expression.AndAlso);
        }

        /// <summary>
        /// Combines boolean expressions with same parameters via AndAlso 
        /// (logical "and" that evaluates the second argument only when the first one is true).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, T2, bool>> CombineViaAndAlso<T1, T2>(
            IEnumerable<Expression<Func<T1, T2, bool>>> expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, T2, bool>>)Combine(
#if NET35 || NET35_CLIENT || NET37_CF
                expressions.Cast<LambdaExpression>(),
#else
                expressions, 
#endif
                Expression.AndAlso);
        }

        /// <summary>
        /// Combines boolean expressions with same parameters via AndAlso 
        /// (logical "and" that evaluates the second argument only when the first one is true).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, T2, T3, bool>> CombineViaAndAlso<T1, T2, T3>(
            IEnumerable<Expression<Func<T1, T2, T3, bool>>> expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, T2, T3, bool>>)Combine(
#if NET35 || NET35_CLIENT || NET37_CF
                expressions.Cast<LambdaExpression>(),
#else
                expressions, 
#endif
                Expression.AndAlso);
        }

        /// <summary>
        /// Combines boolean expressions with same parameters via AndAlso 
        /// (logical "and" that evaluates the second argument only when the first one is true).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, T2, T3, T4, bool>> CombineViaAndAlso<T1, T2, T3, T4>(
            IEnumerable<Expression<Func<T1, T2, T3, T4, bool>>> expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, T2, T3, T4, bool>>)Combine(
#if NET35 || NET35_CLIENT || NET37_CF
                expressions.Cast<LambdaExpression>(),
#else
                expressions, 
#endif
                Expression.AndAlso);
        }

#if !NET35 && !NET35_CLIENT && !NET37_CF
        /// <summary>
        /// Combines boolean expressions with same parameters via AndAlso 
        /// (logical "and" that evaluates the second argument only when the first one is true).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, T2, T3, T4, T5, bool>> CombineViaAndAlso<T1, T2, T3, T4, T5>(
            IEnumerable<Expression<Func<T1, T2, T3, T4, T5, bool>>> expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, T2, T3, T4, T5, bool>>)Combine(expressions, Expression.AndAlso);
        }

        /// <summary>
        /// Combines boolean expressions with same parameters via AndAlso 
        /// (logical "and" that evaluates the second argument only when the first one is true).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, T2, T3, T4, T5, T6, bool>> CombineViaAndAlso<T1, T2, T3, T4, T5, T6>(
            IEnumerable<Expression<Func<T1, T2, T3, T4, T5, T6, bool>>> expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, T2, T3, T4, T5, T6, bool>>)Combine(expressions, Expression.AndAlso);
        }

        /// <summary>
        /// Combines boolean expressions with same parameters via AndAlso 
        /// (logical "and" that evaluates the second argument only when the first one is true).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, T2, T3, T4, T5, T6, T7, bool>> CombineViaAndAlso<T1, T2, T3, T4, T5, T6, T7>(
            IEnumerable<Expression<Func<T1, T2, T3, T4, T5, T6, T7, bool>>> expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, T2, T3, T4, T5, T6, T7, bool>>)Combine(expressions, Expression.AndAlso);
        }

        /// <summary>
        /// Combines boolean expressions with same parameters via AndAlso 
        /// (logical "and" that evaluates the second argument only when the first one is true).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, bool>>
            CombineViaAndAlso<T1, T2, T3, T4, T5, T6, T7, T8>(
                IEnumerable<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, bool>>> expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, bool>>)Combine(expressions, Expression.AndAlso);
        }

        /// <summary>
        /// Combines boolean expressions with same parameters via AndAlso 
        /// (logical "and" that evaluates the second argument only when the first one is true).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool>>
            CombineViaAndAlso<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
                IEnumerable<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool>>> expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool>>)Combine(expressions, Expression.AndAlso);
        }

        /// <summary>
        /// Combines boolean expressions with same parameters via AndAlso 
        /// (logical "and" that evaluates the second argument only when the first one is true).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>>
            CombineViaAndAlso<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
                IEnumerable<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>>> expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>>)Combine(expressions, Expression.AndAlso);
        }

        /// <summary>
        /// Combines boolean expressions with same parameters via AndAlso 
        /// (logical "and" that evaluates the second argument only when the first one is true).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool>>
            CombineViaAndAlso<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
                IEnumerable<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool>>> expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool>>)Combine(
                expressions, 
                Expression.AndAlso);
        }

        /// <summary>
        /// Combines boolean expressions with same parameters via AndAlso 
        /// (logical "and" that evaluates the second argument only when the first one is true).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool>>
            CombineViaAndAlso<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
                IEnumerable<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool>>> expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool>>)Combine(
                expressions, 
                Expression.AndAlso);
        }

        /// <summary>
        /// Combines boolean expressions with same parameters via AndAlso 
        /// (logical "and" that evaluates the second argument only when the first one is true).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool>>
            CombineViaAndAlso<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
                IEnumerable<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool>>> expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool>>)Combine(
                expressions, 
                Expression.AndAlso);
        }

        /// <summary>
        /// Combines boolean expressions with same parameters via AndAlso 
        /// (logical "and" that evaluates the second argument only when the first one is true).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool>>
            CombineViaAndAlso<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
                IEnumerable<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool>>> expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool>>)Combine(
                expressions, 
                Expression.AndAlso);
        }

        /// <summary>
        /// Combines boolean expressions with same parameters via AndAlso 
        /// (logical "and" that evaluates the second argument only when the first one is true).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool>>
            CombineViaAndAlso<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
                IEnumerable<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool>>>
                    expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool>>)Combine(
                expressions, 
                Expression.AndAlso);
        }

        /// <summary>
        /// Combines boolean expressions with same parameters via AndAlso 
        /// (logical "and" that evaluates the second argument only when the first one is true).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool>>
            CombineViaAndAlso<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
                IEnumerable<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool>>>
                    expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool>>)Combine(
                expressions, 
                Expression.AndAlso);
        }
#endif

        /// <summary>
        /// Combines boolean expressions without parameters via OrElse 
        /// (logical "or" that evaluates the second argument only when the first one is false).
        /// </summary>
        /// <param name="expressions">Boolean expressions without parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<bool>> CombineViaOrElse(IEnumerable<Expression<Func<bool>>> expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<bool>>)Combine(
#if NET35 || NET35_CLIENT || NET37_CF
                expressions.Cast<LambdaExpression>(),
#else
                expressions, 
#endif
                Expression.OrElse);
        }

        /// <summary>
        /// Combines boolean expressions with same parameters via OrElse 
        /// (logical "or" that evaluates the second argument only when the first one is false).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, bool>> CombineViaOrElse<T1>(
            IEnumerable<Expression<Func<T1, bool>>> expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, bool>>)Combine(
#if NET35 || NET35_CLIENT || NET37_CF
                expressions.Cast<LambdaExpression>(),
#else
                expressions, 
#endif
                Expression.OrElse);
        }

        /// <summary>
        /// Combines boolean expressions with same parameters via OrElse 
        /// (logical "or" that evaluates the second argument only when the first one is false).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, T2, bool>> CombineViaOrElse<T1, T2>(
            IEnumerable<Expression<Func<T1, T2, bool>>> expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, T2, bool>>)Combine(
#if NET35 || NET35_CLIENT || NET37_CF
                expressions.Cast<LambdaExpression>(),
#else
                expressions, 
#endif
                Expression.OrElse);
        }

        /// <summary>
        /// Combines boolean expressions with same parameters via OrElse 
        /// (logical "or" that evaluates the second argument only when the first one is false).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, T2, T3, bool>> CombineViaOrElse<T1, T2, T3>(
            IEnumerable<Expression<Func<T1, T2, T3, bool>>> expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, T2, T3, bool>>)Combine(
#if NET35 || NET35_CLIENT || NET37_CF
                expressions.Cast<LambdaExpression>(),
#else
                expressions, 
#endif
                Expression.OrElse);
        }

        /// <summary>
        /// Combines boolean expressions with same parameters via OrElse 
        /// (logical "or" that evaluates the second argument only when the first one is false).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, T2, T3, T4, bool>> CombineViaOrElse<T1, T2, T3, T4>(
            IEnumerable<Expression<Func<T1, T2, T3, T4, bool>>> expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, T2, T3, T4, bool>>)Combine(
#if NET35 || NET35_CLIENT || NET37_CF
                expressions.Cast<LambdaExpression>(),
#else
                expressions, 
#endif
                Expression.OrElse);
        }

#if !NET35 && !NET35_CLIENT && !NET37_CF
        /// <summary>
        /// Combines boolean expressions with same parameters via OrElse 
        /// (logical "or" that evaluates the second argument only when the first one is false).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, T2, T3, T4, T5, bool>> CombineViaOrElse<T1, T2, T3, T4, T5>(
            IEnumerable<Expression<Func<T1, T2, T3, T4, T5, bool>>> expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, T2, T3, T4, T5, bool>>)Combine(expressions, Expression.OrElse);
        }

        /// <summary>
        /// Combines boolean expressions with same parameters via OrElse 
        /// (logical "or" that evaluates the second argument only when the first one is false).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, T2, T3, T4, T5, T6, bool>> CombineViaOrElse<T1, T2, T3, T4, T5, T6>(
            IEnumerable<Expression<Func<T1, T2, T3, T4, T5, T6, bool>>> expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, T2, T3, T4, T5, T6, bool>>)Combine(expressions, Expression.OrElse);
        }

        /// <summary>
        /// Combines boolean expressions with same parameters via OrElse 
        /// (logical "or" that evaluates the second argument only when the first one is false).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, T2, T3, T4, T5, T6, T7, bool>> CombineViaOrElse<T1, T2, T3, T4, T5, T6, T7>(
            IEnumerable<Expression<Func<T1, T2, T3, T4, T5, T6, T7, bool>>> expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, T2, T3, T4, T5, T6, T7, bool>>)Combine(expressions, Expression.OrElse);
        }

        /// <summary>
        /// Combines boolean expressions with same parameters via OrElse 
        /// (logical "or" that evaluates the second argument only when the first one is false).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, bool>>
            CombineViaOrElse<T1, T2, T3, T4, T5, T6, T7, T8>(
                IEnumerable<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, bool>>> expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, bool>>)Combine(expressions, Expression.OrElse);
        }

        /// <summary>
        /// Combines boolean expressions with same parameters via OrElse 
        /// (logical "or" that evaluates the second argument only when the first one is false).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool>>
            CombineViaOrElse<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
                IEnumerable<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool>>> expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool>>)Combine(expressions, Expression.OrElse);
        }

        /// <summary>
        /// Combines boolean expressions with same parameters via OrElse 
        /// (logical "or" that evaluates the second argument only when the first one is false).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>>
            CombineViaOrElse<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
                IEnumerable<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>>> expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>>)Combine(expressions, Expression.OrElse);
        }

        /// <summary>
        /// Combines boolean expressions with same parameters via OrElse 
        /// (logical "or" that evaluates the second argument only when the first one is false).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool>>
            CombineViaOrElse<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
                IEnumerable<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool>>> expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool>>)Combine(expressions, Expression.OrElse);
        }

        /// <summary>
        /// Combines boolean expressions with same parameters via OrElse 
        /// (logical "or" that evaluates the second argument only when the first one is false).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool>>
            CombineViaOrElse<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
                IEnumerable<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool>>> expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool>>)Combine(
                expressions, 
                Expression.OrElse);
        }

        /// <summary>
        /// Combines boolean expressions with same parameters via OrElse 
        /// (logical "or" that evaluates the second argument only when the first one is false).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool>>
            CombineViaOrElse<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
                IEnumerable<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool>>> expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool>>)Combine(
                expressions, 
                Expression.OrElse);
        }

        /// <summary>
        /// Combines boolean expressions with same parameters via OrElse 
        /// (logical "or" that evaluates the second argument only when the first one is false).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool>>
            CombineViaOrElse<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
                IEnumerable<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool>>> expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool>>)Combine(
                expressions, 
                Expression.OrElse);
        }

        /// <summary>
        /// Combines boolean expressions with same parameters via OrElse 
        /// (logical "or" that evaluates the second argument only when the first one is false).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool>>
            CombineViaOrElse<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
                IEnumerable<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool>>>
                    expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool>>)Combine(
                expressions, 
                Expression.OrElse);
        }

        /// <summary>
        /// Combines boolean expressions with same parameters via OrElse 
        /// (logical "or" that evaluates the second argument only when the first one is false).
        /// </summary>
        /// <param name="expressions">Boolean expressions with same parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool>>
            CombineViaOrElse<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
                IEnumerable<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool>>>
                    expressions)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));

            return (Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool>>)Combine(
                expressions, 
                Expression.OrElse);
        }
#endif

        private static LambdaExpression Combine(
            IEnumerable<LambdaExpression> expressions,
            Func<Expression, Expression, Expression> operation)
        {
            if (expressions == null)
                throw new ArgumentNullException(nameof(expressions));
            if (operation == null)
                throw new ArgumentNullException(nameof(operation));

            LambdaExpression firstExpression = null;
            Expression resultBody = null;
            IList<ParameterExpression> resultParameters = null;
            foreach (var expression in expressions)
            {
                if (expression == null)
                    throw new ArgumentException("Expression list contains null.", nameof(expressions));

                if (resultBody == null)
                {
                    firstExpression = expression;
                    resultBody = expression.Body;
                    resultParameters = expression.Parameters;
                }
                else
                {
                    if (expression.Parameters.Count != firstExpression.Parameters.Count)
                        throw new ArgumentException(
                            $"Expressions have different parameter count.\n{firstExpression}\n{expression}", 
                            nameof(expressions));
                    for (var parameterIndex = 0; parameterIndex < expression.Parameters.Count; parameterIndex++)
                        if (expression.Parameters[parameterIndex].Type != firstExpression.Parameters[parameterIndex].Type)
                            throw new ArgumentException(
                                $"Expressions have different parameter types.\n{firstExpression}\n{expression}\n" +
                                    $"Parameter #{parameterIndex + 1}.\n{firstExpression.Parameters[parameterIndex].Type}\n" +
                                    $"{expression.Parameters[parameterIndex].Type}", 
                                nameof(expressions));

                    var parameterSubstitutions = new Dictionary<ParameterExpression, Expression>(resultParameters.Count);
                    for (var parameterIndex = 0; parameterIndex < resultParameters.Count; parameterIndex++)
                        parameterSubstitutions.Add(expression.Parameters[parameterIndex], resultParameters[parameterIndex]);
                    resultBody = operation(
                        resultBody,
                        ExpressionParameterSubstitutor.SubstituteParameters(expression.Body, parameterSubstitutions));
                }
            }
            if (firstExpression == null)
                throw new ArgumentException("Expression list is empty.", nameof(expressions));
            return Expression.Lambda(
                resultBody,
#if NET35 || NET35_CLIENT || NET37_CF
                resultParameters.ToArray());
#else
                resultParameters);
#endif
        }
    }
}
