using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Expressions;

namespace IharBury.Expressions
{
    /// <summary>
    /// Combines boolean expressions.
    /// </summary>
    [Pure]
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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(Contract.Result<Expression<Func<bool>>>() != null);

            return (Expression<Func<bool>>)Combine(expressions, Expression.AndAlso);
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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(Contract.Result<Expression<Func<T1, bool>>>() != null);

            return (Expression<Func<T1, bool>>)Combine(expressions, Expression.AndAlso);
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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(Contract.Result<Expression<Func<T1, T2, bool>>>() != null);

            return (Expression<Func<T1, T2, bool>>)Combine(expressions, Expression.AndAlso);
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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(Contract.Result<Expression<Func<T1, T2, T3, bool>>>() != null);

            return (Expression<Func<T1, T2, T3, bool>>)Combine(expressions, Expression.AndAlso);
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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(Contract.Result<Expression<Func<T1, T2, T3, T4, bool>>>() != null);

            return (Expression<Func<T1, T2, T3, T4, bool>>)Combine(expressions, Expression.AndAlso);
        }

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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(Contract.Result<Expression<Func<T1, T2, T3, T4, T5, bool>>>() != null);

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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(Contract.Result<Expression<Func<T1, T2, T3, T4, T5, T6, bool>>>() != null);

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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(Contract.Result<Expression<Func<T1, T2, T3, T4, T5, T6, T7, bool>>>() != null);

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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(Contract.Result<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, bool>>>() != null);

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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(Contract.Result<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool>>>() != null);

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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(Contract.Result<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>>>() != null);

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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(Contract.Result<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool>>>() != null);

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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(
                Contract.Result<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool>>>() != null);

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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(
                Contract.Result<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool>>>() != null);

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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(
                Contract.Result<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool>>>() != null);

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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(
                Contract.Result<
                    Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool>>>() != null);

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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(
                Contract.Result<
                    Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool>>>() != null);

            return (Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool>>)Combine(
                expressions, 
                Expression.AndAlso);
        }

        /// <summary>
        /// Combines boolean expressions without parameters via OrElse 
        /// (logical "or" that evaluates the second argument only when the first one is false).
        /// </summary>
        /// <param name="expressions">Boolean expressions without parameters to be combined.
        /// Cannot be null. Cannot be empty. Cannot contain null values.</param>
        /// <returns>Combined expression.</returns>
        public static Expression<Func<bool>> CombineViaOrElse(IEnumerable<Expression<Func<bool>>> expressions)
        {
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(Contract.Result<Expression<Func<bool>>>() != null);

            return (Expression<Func<bool>>)Combine(expressions, Expression.OrElse);
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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(Contract.Result<Expression<Func<T1, bool>>>() != null);

            return (Expression<Func<T1, bool>>)Combine(expressions, Expression.OrElse);
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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(Contract.Result<Expression<Func<T1, T2, bool>>>() != null);

            return (Expression<Func<T1, T2, bool>>)Combine(expressions, Expression.OrElse);
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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(Contract.Result<Expression<Func<T1, T2, T3, bool>>>() != null);

            return (Expression<Func<T1, T2, T3, bool>>)Combine(expressions, Expression.OrElse);
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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(Contract.Result<Expression<Func<T1, T2, T3, T4, bool>>>() != null);

            return (Expression<Func<T1, T2, T3, T4, bool>>)Combine(expressions, Expression.OrElse);
        }

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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(Contract.Result<Expression<Func<T1, T2, T3, T4, T5, bool>>>() != null);

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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(Contract.Result<Expression<Func<T1, T2, T3, T4, T5, T6, bool>>>() != null);

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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(Contract.Result<Expression<Func<T1, T2, T3, T4, T5, T6, T7, bool>>>() != null);

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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(Contract.Result<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, bool>>>() != null);

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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(Contract.Result<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool>>>() != null);

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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(Contract.Result<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>>>() != null);

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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(Contract.Result<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool>>>() != null);

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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(
                Contract.Result<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool>>>() != null);

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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(
                Contract.Result<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool>>>() != null);

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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(
                Contract.Result<Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool>>>() != null);

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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(
                Contract.Result<
                    Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool>>>() != null);

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
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Ensures(
                Contract.Result<
                    Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool>>>() != null);

            return (Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool>>)Combine(
                expressions, 
                Expression.OrElse);
        }

        private static LambdaExpression Combine(
            IEnumerable<LambdaExpression> expressions,
            Func<Expression, Expression, Expression> operation)
        {
            Contract.Requires<ArgumentNullException>(expressions != null);
            Contract.Requires<ArgumentNullException>(operation != null);
            Contract.Requires(Contract.Exists(expressions, expression => true));
            Contract.Requires(Contract.ForAll(expressions, expression => expression != null));
            Contract.Requires(Contract.ForAll(
                expressions, 
                expression => expression.Parameters.Count == expressions.First().Parameters.Count));
            Contract.Requires(Contract.ForAll(
                expressions,
                expression => Contract.ForAll(
                    Enumerable.Range(0, expression.Parameters.Count),
                    parameterIndex => expression.Parameters[parameterIndex].Type == 
                        expressions.First().Parameters[parameterIndex].Type)));
            Contract.Ensures(Contract.Result<LambdaExpression>() != null);

            Expression resultBody = null;
            IReadOnlyList<ParameterExpression> resultParameters = null;
            foreach (var expression in expressions)
            {
                if (resultBody == null)
                {
                    resultBody = expression.Body;
                    resultParameters = expression.Parameters;
                }
                else
                {
                    var parameterSubstitutions = new Dictionary<ParameterExpression, Expression>(resultParameters.Count);
                    for (var parameterIndex = 0; parameterIndex < resultParameters.Count; parameterIndex++)
                        parameterSubstitutions.Add(expression.Parameters[parameterIndex], resultParameters[parameterIndex]);
                    resultBody = operation(
                        resultBody,
                        ExpressionParameterSubstitutor.SubstituteParameters(expression.Body, parameterSubstitutions));
                }
            }
            return Expression.Lambda(resultBody, resultParameters);
        }
    }
}
