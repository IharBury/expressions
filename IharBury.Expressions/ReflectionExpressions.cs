using System;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace IharBury.Expressions
{
    /// <summary>
    /// Allows acquiring MemberInfo objects and member names in a refactoring friendly way via expressions.
    /// </summary>
    [Pure]
    public static class ReflectionExpressions
    {
        private const string GetterSpecialNamePrefix = "get_";

        /// <summary>
        /// Tries to find <c>MethodInfo</c> via the method call expression.
        /// This overload is for instance methods (and extension methods) with return value.
        /// </summary>
        /// <typeparam name="TObject">Declaring type for instance methods. First parameter type for extension methods.</typeparam>
        /// <param name="callExpression">Method call expression. Can contain any valid argument values.</param>
        /// <returns><c>MethodInfo</c> or null (if the expression is not a method call expression).</returns>
        public static MethodInfo TryGetMethodInfo<TObject>(Expression<Func<TObject, object>> callExpression)
        {
            return TryGetMethodInfo((LambdaExpression)callExpression);
        }

        /// <summary>
        /// Tries to find <c>MethodInfo</c> via the method call expression.
        /// This overload is for instance methods (and extension methods) without return value.
        /// </summary>
        /// <typeparam name="TObject">Declaring type for instance methods. First parameter type for extension methods.</typeparam>
        /// <param name="callExpression">Method call expression. Can contain any valid argument values.</param>
        /// <returns><c>MethodInfo</c> or null (if the expression is not a method call expression).</returns>
        public static MethodInfo TryGetMethodInfo<TObject>(Expression<Action<TObject>> callExpression)
        {
            return TryGetMethodInfo((LambdaExpression)callExpression);
        }

        /// <summary>
        /// Tries to find <c>MethodInfo</c> via the method call expression.
        /// This overload is for static methods with return value.
        /// </summary>
        /// <param name="callExpression">Method call expression. Can contain any valid argument values.</param>
        /// <returns><c>MethodInfo</c> or null (if the expression is not a method call expression).</returns>
        public static MethodInfo TryGetMethodInfo(Expression<Func<object>> callExpression)
        {
            return TryGetMethodInfo((LambdaExpression)callExpression);
        }

        /// <summary>
        /// Tries to find <c>MethodInfo</c> via the method call expression.
        /// This overload is for static methods without return value.
        /// </summary>
        /// <param name="callExpression">Method call expression. Can contain any valid argument values.</param>
        /// <returns><c>MethodInfo</c> or null (if the expression is not a method call expression).</returns>
        public static MethodInfo TryGetMethodInfo(Expression<Action> callExpression)
        {
            return TryGetMethodInfo((LambdaExpression)callExpression);
        }

        /// <summary>
        /// Tries to find <c>MethodInfo</c> via the method call expression.
        /// This overload is for cases when you already have the expression object.
        /// </summary>
        /// <param name="callExpression">Method call expression. Can contain any valid argument values.</param>
        /// <returns><c>MethodInfo</c> or null (if the expression is not a method call expression).</returns>
        public static MethodInfo TryGetMethodInfo(LambdaExpression callExpression)
        {
            if (callExpression == null)
                return null;

            var effectiveExpression = RemoveConverts(callExpression.Body);
            switch (effectiveExpression.NodeType)
            {
                case ExpressionType.Call:
                    return ((MethodCallExpression)effectiveExpression).Method;

                default:
                    return null;
            }
        }

        /// <summary>
        /// Finds <c>MethodInfo</c> via the method call expression.
        /// This overload is for instance methods (and extension methods) with return value.
        /// </summary>
        /// <typeparam name="TObject">Declaring type for instance methods. First parameter type for extension methods.</typeparam>
        /// <param name="callExpression">Method call expression. Can contain any valid argument values.</param>
        public static MethodInfo GetMethodInfo<TObject>(Expression<Func<TObject, object>> callExpression)
        {
            Contract.Requires<ArgumentNullException>(callExpression != null);
            Contract.Requires(TryGetMethodInfo(callExpression) != null);
            Contract.Ensures(Contract.Result<MethodInfo>() != null);

            return GetMethodInfo((LambdaExpression)callExpression);
        }

        /// <summary>
        /// Finds <c>MethodInfo</c> via the method call expression.
        /// This overload is for instance methods (and extension methods) without return value.
        /// </summary>
        /// <typeparam name="TObject">Declaring type for instance methods. First parameter type for extension methods.</typeparam>
        /// <param name="callExpression">Method call expression. Can contain any valid argument values.</param>
        public static MethodInfo GetMethodInfo<TObject>(Expression<Action<TObject>> callExpression)
        {
            Contract.Requires<ArgumentNullException>(callExpression != null);
            Contract.Requires(TryGetMethodInfo(callExpression) != null);
            Contract.Ensures(Contract.Result<MethodInfo>() != null);

            return GetMethodInfo((LambdaExpression)callExpression);
        }

        /// <summary>
        /// Finds <c>MethodInfo</c> via the method call expression.
        /// This overload is for static methods with return value.
        /// </summary>
        /// <param name="callExpression">Method call expression. Can contain any valid argument values.</param>
        public static MethodInfo GetMethodInfo(Expression<Func<object>> callExpression)
        {
            Contract.Requires<ArgumentNullException>(callExpression != null);
            Contract.Requires(TryGetMethodInfo(callExpression) != null);
            Contract.Ensures(Contract.Result<MethodInfo>() != null);

            return GetMethodInfo((LambdaExpression)callExpression);
        }

        /// <summary>
        /// Finds <c>MethodInfo</c> via the method call expression.
        /// This overload is for static methods without return value.
        /// </summary>
        /// <param name="callExpression">Method call expression. Can contain any valid argument values.</param>
        public static MethodInfo GetMethodInfo(Expression<Action> callExpression)
        {
            Contract.Requires<ArgumentNullException>(callExpression != null);
            Contract.Requires(TryGetMethodInfo(callExpression) != null);
            Contract.Ensures(Contract.Result<MethodInfo>() != null);

            return GetMethodInfo((LambdaExpression)callExpression);
        }

        /// <summary>
        /// Finds <c>MethodInfo</c> via the method call expression.
        /// This overload is for cases when you already have the expression object.
        /// </summary>
        /// <param name="callExpression">Method call expression. Can contain any valid argument values.</param>
        public static MethodInfo GetMethodInfo(LambdaExpression callExpression)
        {
            Contract.Requires<ArgumentNullException>(callExpression != null);
            Contract.Requires(TryGetMethodInfo(callExpression) != null);
            Contract.Ensures(Contract.Result<MethodInfo>() != null);

            var methodInfo = TryGetMethodInfo(callExpression);
            Contract.Assert(methodInfo != null);
            return methodInfo;
        }

        /// <summary>
        /// Tries to find method name via the method call expression.
        /// This overload is for instance methods (and extension methods) with return value.
        /// </summary>
        /// <typeparam name="TObject">Declaring type for instance methods. First parameter type for extension methods.</typeparam>
        /// <param name="callExpression">Method call expression. Can contain any valid argument values.</param>
        /// <returns>Method name or null (if the expression is not a method call expression).</returns>
        public static string TryGetMethodName<TObject>(Expression<Func<TObject, object>> callExpression)
        {
            return TryGetMethodName((LambdaExpression)callExpression);
        }

        /// <summary>
        /// Tries to find method name via the method call expression.
        /// This overload is for instance methods (and extension methods) without return value.
        /// </summary>
        /// <typeparam name="TObject">Declaring type for instance methods. First parameter type for extension methods.</typeparam>
        /// <param name="callExpression">Method call expression. Can contain any valid argument values.</param>
        /// <returns>Method name or null (if the expression is not a method call expression).</returns>
        public static string TryGetMethodName<TObject>(Expression<Action<TObject>> callExpression)
        {
            return TryGetMethodName((LambdaExpression)callExpression);
        }

        /// <summary>
        /// Tries to find method name via the method call expression.
        /// This overload is for static methods with return value.
        /// </summary>
        /// <param name="callExpression">Method call expression. Can contain any valid argument values.</param>
        /// <returns>Method name or null (if the expression is not a method call expression).</returns>
        public static string TryGetMethodName(Expression<Func<object>> callExpression)
        {
            return TryGetMethodName((LambdaExpression)callExpression);
        }

        /// <summary>
        /// Tries to find method name via the method call expression.
        /// This overload is for static methods without return value.
        /// </summary>
        /// <param name="callExpression">Method call expression. Can contain any valid argument values.</param>
        /// <returns>Method name or null (if the expression is not a method call expression).</returns>
        public static string TryGetMethodName(Expression<Action> callExpression)
        {
            return TryGetMethodName((LambdaExpression)callExpression);
        }

        /// <summary>
        /// Tries to find method name via the method call expression.
        /// This overload is for cases when you already have the expression object.
        /// </summary>
        /// <param name="callExpression">Method call expression. Can contain any valid argument values.</param>
        /// <returns>Method name or null (if the expression is not a method call expression).</returns>
        public static string TryGetMethodName(LambdaExpression callExpression)
        {
            return TryGetMethodInfo(callExpression)?.Name;
        }

        /// <summary>
        /// Finds method name via the method call expression.
        /// This overload is for instance methods (and extension methods) with return value.
        /// </summary>
        /// <typeparam name="TObject">Declaring type for instance methods. First parameter type for extension methods.</typeparam>
        /// <param name="callExpression">Method call expression. Can contain any valid argument values.</param>
        public static string GetMethodName<TObject>(Expression<Func<TObject, object>> callExpression)
        {
            Contract.Requires<ArgumentNullException>(callExpression != null);
            Contract.Requires(TryGetMethodInfo(callExpression) != null);
            Contract.Ensures(Contract.Result<string>() != null);

            return GetMethodName((LambdaExpression)callExpression);
        }

        /// <summary>
        /// Finds method name via the method call expression.
        /// This overload is for instance methods (and extension methods) without return value.
        /// </summary>
        /// <typeparam name="TObject">Declaring type for instance methods. First parameter type for extension methods.</typeparam>
        /// <param name="callExpression">Method call expression. Can contain any valid argument values.</param>
        public static string GetMethodName<TObject>(Expression<Action<TObject>> callExpression)
        {
            Contract.Requires<ArgumentNullException>(callExpression != null);
            Contract.Requires(TryGetMethodInfo(callExpression) != null);
            Contract.Ensures(Contract.Result<string>() != null);

            return GetMethodName((LambdaExpression)callExpression);
        }

        /// <summary>
        /// Finds method name via the method call expression.
        /// This overload is for static methods with return value.
        /// </summary>
        /// <param name="callExpression">Method call expression. Can contain any valid argument values.</param>
        public static string GetMethodName(Expression<Func<object>> callExpression)
        {
            Contract.Requires<ArgumentNullException>(callExpression != null);
            Contract.Requires(TryGetMethodInfo(callExpression) != null);
            Contract.Ensures(Contract.Result<string>() != null);

            return GetMethodName((LambdaExpression)callExpression);
        }

        /// <summary>
        /// Finds method name via the method call expression.
        /// This overload is for static methods without return value.
        /// </summary>
        /// <param name="callExpression">Method call expression. Can contain any valid argument values.</param>
        public static string GetMethodName(Expression<Action> callExpression)
        {
            Contract.Requires<ArgumentNullException>(callExpression != null);
            Contract.Requires(TryGetMethodInfo(callExpression) != null);
            Contract.Ensures(Contract.Result<string>() != null);

            return GetMethodName((LambdaExpression)callExpression);
        }

        /// <summary>
        /// Finds method name via the method call expression.
        /// This overload is for cases when you already have the expression object.
        /// </summary>
        /// <param name="callExpression">Method call expression. Can contain any valid argument values.</param>
        public static string GetMethodName(LambdaExpression callExpression)
        {
            Contract.Requires<ArgumentNullException>(callExpression != null);
            Contract.Requires(TryGetMethodInfo(callExpression) != null);
            Contract.Ensures(Contract.Result<string>() != null);

            return GetMethodInfo(callExpression).Name;
        }

        /// <summary>
        /// Tries to find <c>PropertyInfo</c> via the property access expression.
        /// This overload is for instance properties.
        /// </summary>
        /// <typeparam name="TObject">Declaring type.</typeparam>
        /// <param name="propertyExpression">Property access expression.
        /// Can contain any valid argument values for indexed properties.</param>
        /// <returns><c>PropertyInfo</c> or null (if the expression is not a property access expression).</returns>
        public static PropertyInfo TryGetPropertyInfo<TObject>(Expression<Func<TObject, object>> propertyExpression)
        {
            return TryGetPropertyInfo((LambdaExpression)propertyExpression);
        }

        /// <summary>
        /// Tries to find <c>PropertyInfo</c> via the property access expression.
        /// This overload is for static properties.
        /// </summary>
        /// <param name="propertyExpression">Property access expression.
        /// Can contain any valid argument values for indexed properties.</param>
        /// <returns><c>PropertyInfo</c> or null (if the expression is not a property access expression).</returns>
        public static PropertyInfo TryGetPropertyInfo(Expression<Func<object>> propertyExpression)
        {
            return TryGetPropertyInfo((LambdaExpression)propertyExpression);
        }

        /// <summary>
        /// Tries to find <c>PropertyInfo</c> via the property access expression.
        /// This overload is for cases when you already have the expression object.
        /// </summary>
        /// <param name="propertyExpression">Property access expression.
        /// Can contain any valid argument values for indexed properties.</param>
        /// <returns><c>PropertyInfo</c> or null (if the expression is not a property access expression).</returns>
        public static PropertyInfo TryGetPropertyInfo(LambdaExpression propertyExpression)
        {
            if (propertyExpression == null)
                return null;

            var effectiveExpression = RemoveConverts(propertyExpression.Body);
            switch (effectiveExpression.NodeType)
            {
                case ExpressionType.MemberAccess:
                    return ((MemberExpression)effectiveExpression).Member as PropertyInfo;

                case ExpressionType.Call:
                    var methodCallExpression = (MethodCallExpression)effectiveExpression;
                    if (methodCallExpression.Method.IsSpecialName &&
                            methodCallExpression.Method.Name.StartsWith(GetterSpecialNamePrefix, StringComparison.Ordinal) &&
                            (methodCallExpression.Method.DeclaringType != null))
                        return methodCallExpression
                            .Method
                            .DeclaringType
                            .GetTypeInfo()
                            .DeclaredProperties.SingleOrDefault(property => property.GetMethod == methodCallExpression.Method);
                    return null;

                default:
                    return null;
            }
        }

        /// <summary>
        /// Finds <c>PropertyInfo</c> via the property access expression.
        /// This overload is for instance properties.
        /// </summary>
        /// <typeparam name="TObject">Declaring type.</typeparam>
        /// <param name="propertyExpression">Property access expression.
        /// Can contain any valid argument values for indexed properties.</param>
        public static PropertyInfo GetPropertyInfo<TObject>(Expression<Func<TObject, object>> propertyExpression)
        {
            Contract.Requires<ArgumentNullException>(propertyExpression != null);
            Contract.Requires(TryGetPropertyInfo(propertyExpression) != null);
            Contract.Ensures(Contract.Result<PropertyInfo>() != null);

            return GetPropertyInfo((LambdaExpression)propertyExpression);
        }

        /// <summary>
        /// Finds <c>PropertyInfo</c> via the property access expression.
        /// This overload is for static properties.
        /// </summary>
        /// <param name="propertyExpression">Property access expression.
        /// Can contain any valid argument values for indexed properties.</param>
        public static PropertyInfo GetPropertyInfo(Expression<Func<object>> propertyExpression)
        {
            Contract.Requires<ArgumentNullException>(propertyExpression != null);
            Contract.Requires(TryGetPropertyInfo(propertyExpression) != null);
            Contract.Ensures(Contract.Result<PropertyInfo>() != null);

            return GetPropertyInfo((LambdaExpression)propertyExpression);
        }

        /// <summary>
        /// Finds <c>PropertyInfo</c> via the property access expression.
        /// This overload is for cases when you already have the expression object.
        /// </summary>
        /// <param name="propertyExpression">Property access expression.
        /// Can contain any valid argument values for indexed properties.</param>
        public static PropertyInfo GetPropertyInfo(LambdaExpression propertyExpression)
        {
            Contract.Requires<ArgumentNullException>(propertyExpression != null);
            Contract.Requires(TryGetPropertyInfo(propertyExpression) != null);
            Contract.Ensures(Contract.Result<PropertyInfo>() != null);

            var propertyInfo = TryGetPropertyInfo(propertyExpression);
            Contract.Assert(propertyInfo != null);
            return propertyInfo;
        }

        /// <summary>
        /// Tries to find property name via the property access expression.
        /// This overload is for instance properties.
        /// </summary>
        /// <typeparam name="TObject">Declaring type.</typeparam>
        /// <param name="propertyExpression">Property access expression.
        /// Can contain any valid argument values for indexed properties.</param>
        /// <returns>Property name or null (if the expression is not a property access expression).</returns>
        public static string TryGetPropertyName<TObject>(Expression<Func<TObject, object>> propertyExpression)
        {
            return TryGetPropertyName((LambdaExpression)propertyExpression);
        }

        /// <summary>
        /// Tries to find property name via the property access expression.
        /// This overload is for static properties.
        /// </summary>
        /// <param name="propertyExpression">Property access expression.
        /// Can contain any valid argument values for indexed properties.</param>
        /// <returns>Property name or null (if the expression is not a property access expression).</returns>
        public static string TryGetPropertyName(Expression<Func<object>> propertyExpression)
        {
            return TryGetPropertyName((LambdaExpression)propertyExpression);
        }

        /// <summary>
        /// Tries to find property name via the property access expression.
        /// This overload is for cases when you already have the expression object.
        /// </summary>
        /// <param name="propertyExpression">Property access expression.
        /// Can contain any valid argument values for indexed properties.</param>
        /// <returns>Property name or null (if the expression is not a property access expression).</returns>
        public static string TryGetPropertyName(LambdaExpression propertyExpression)
        {
            return TryGetPropertyInfo(propertyExpression)?.Name;
        }

        /// <summary>
        /// Finds property name via the property access expression.
        /// This overload is for instance properties.
        /// </summary>
        /// <typeparam name="TObject">Declaring type.</typeparam>
        /// <param name="propertyExpression">Property access expression.
        /// Can contain any valid argument values for indexed properties.</param>
        public static string GetPropertyName<TObject>(Expression<Func<TObject, object>> propertyExpression)
        {
            Contract.Requires<ArgumentNullException>(propertyExpression != null);
            Contract.Requires(TryGetPropertyInfo(propertyExpression) != null);
            Contract.Ensures(Contract.Result<string>() != null);

            return GetPropertyName((LambdaExpression)propertyExpression);
        }

        /// <summary>
        /// Finds property name via the property access expression.
        /// This overload is for static properties.
        /// </summary>
        /// <param name="propertyExpression">Property access expression.
        /// Can contain any valid argument values for indexed properties.</param>
        public static string GetPropertyName(Expression<Func<object>> propertyExpression)
        {
            Contract.Requires<ArgumentNullException>(propertyExpression != null);
            Contract.Requires(TryGetPropertyInfo(propertyExpression) != null);
            Contract.Ensures(Contract.Result<string>() != null);

            return GetPropertyName((LambdaExpression)propertyExpression);
        }

        /// <summary>
        /// Finds property name via the property access expression.
        /// This overload is for cases when you already have the expression object.
        /// </summary>
        /// <param name="propertyExpression">Property access expression.
        /// Can contain any valid argument values for indexed properties.</param>
        public static string GetPropertyName(LambdaExpression propertyExpression)
        {
            Contract.Requires<ArgumentNullException>(propertyExpression != null);
            Contract.Requires(TryGetPropertyInfo(propertyExpression) != null);
            Contract.Ensures(Contract.Result<string>() != null);

            return GetPropertyInfo(propertyExpression).Name;
        }

        /// <summary>
        /// Tries to find <c>FieldInfo</c> via the field access expression.
        /// This overload is for instance fields.
        /// </summary>
        /// <typeparam name="TObject">Declaring type.</typeparam>
        /// <param name="fieldExpression">Field access expression.</param>
        /// <returns><c>FieldInfo</c> or null (if the expression is not a field access expression).</returns>
        public static FieldInfo TryGetFieldInfo<TObject>(Expression<Func<TObject, object>> fieldExpression)
        {
            return TryGetFieldInfo((LambdaExpression)fieldExpression);
        }

        /// <summary>
        /// Tries to find <c>FieldInfo</c> via the field access expression.
        /// This overload is for static fields.
        /// </summary>
        /// <param name="fieldExpression">Field access expression.</param>
        /// <returns><c>FieldInfo</c> or null (if the expression is not a field access expression).</returns>
        public static FieldInfo TryGetFieldInfo(Expression<Func<object>> fieldExpression)
        {
            return TryGetFieldInfo((LambdaExpression)fieldExpression);
        }

        /// <summary>
        /// Tries to find <c>FieldInfo</c> via the field access expression.
        /// This overload is for cases when you already have the expression object.
        /// </summary>
        /// <param name="fieldExpression">Field access expression.</param>
        /// <returns><c>FieldInfo</c> or null (if the expression is not a field access expression).</returns>
        public static FieldInfo TryGetFieldInfo(LambdaExpression fieldExpression)
        {
            if (fieldExpression == null)
                return null;

            var effectiveExpression = RemoveConverts(fieldExpression.Body);
            switch (effectiveExpression.NodeType)
            {
                case ExpressionType.MemberAccess:
                    return ((MemberExpression)effectiveExpression).Member as FieldInfo;

                default:
                    return null;
            }
        }

        /// <summary>
        /// Finds <c>FieldInfo</c> via the field access expression.
        /// This overload is for instance fields.
        /// </summary>
        /// <typeparam name="TObject">Declaring type.</typeparam>
        /// <param name="fieldExpression">Field access expression.</param>
        public static FieldInfo GetFieldInfo<TObject>(Expression<Func<TObject, object>> fieldExpression)
        {
            Contract.Requires<ArgumentNullException>(fieldExpression != null);
            Contract.Requires(TryGetFieldInfo(fieldExpression) != null);
            Contract.Ensures(Contract.Result<FieldInfo>() != null);

            return GetFieldInfo((LambdaExpression)fieldExpression);
        }

        /// <summary>
        /// Finds <c>FieldInfo</c> via the field access expression.
        /// This overload is for static fields.
        /// </summary>
        /// <param name="fieldExpression">Field access expression.</param>
        public static FieldInfo GetFieldInfo(Expression<Func<object>> fieldExpression)
        {
            Contract.Requires<ArgumentNullException>(fieldExpression != null);
            Contract.Requires(TryGetFieldInfo(fieldExpression) != null);
            Contract.Ensures(Contract.Result<FieldInfo>() != null);

            return GetFieldInfo((LambdaExpression)fieldExpression);
        }

        /// <summary>
        /// Finds <c>FieldInfo</c> via the field access expression.
        /// This overload is for cases when you already have the expression object.
        /// </summary>
        /// <param name="fieldExpression">Field access expression.</param>
        public static FieldInfo GetFieldInfo(LambdaExpression fieldExpression)
        {
            Contract.Requires<ArgumentNullException>(fieldExpression != null);
            Contract.Requires(TryGetFieldInfo(fieldExpression) != null);
            Contract.Ensures(Contract.Result<FieldInfo>() != null);

            var fieldInfo = TryGetFieldInfo(fieldExpression);
            Contract.Assert(fieldInfo != null);
            return fieldInfo;
        }

        /// <summary>
        /// Tries to find field name via the field access expression.
        /// This overload is for instance fields.
        /// </summary>
        /// <typeparam name="TObject">Declaring type.</typeparam>
        /// <param name="fieldExpression">Field access expression.</param>
        /// <returns>Field name or null (if the expression is not a field access expression).</returns>
        public static string TryGetFieldName<TObject>(Expression<Func<TObject, object>> fieldExpression)
        {
            return TryGetFieldName((LambdaExpression)fieldExpression);
        }

        /// <summary>
        /// Tries to find field name via the field access expression.
        /// This overload is for static fields.
        /// </summary>
        /// <param name="fieldExpression">Field access expression.</param>
        /// <returns>Field name or null (if the expression is not a field access expression).</returns>
        public static string TryGetFieldName(Expression<Func<object>> fieldExpression)
        {
            return TryGetFieldName((LambdaExpression)fieldExpression);
        }

        /// <summary>
        /// Tries to find field name via the field access expression.
        /// This overload is for cases when you already have the expression object.
        /// </summary>
        /// <param name="fieldExpression">Field access expression.</param>
        /// <returns>Field name or null (if the expression is not a field access expression).</returns>
        public static string TryGetFieldName(LambdaExpression fieldExpression)
        {
            return TryGetFieldInfo(fieldExpression)?.Name;
        }

        /// <summary>
        /// Finds field name via the field access expression.
        /// This overload is for instance fields.
        /// </summary>
        /// <typeparam name="TObject">Declaring type.</typeparam>
        /// <param name="fieldExpression">Field access expression.</param>
        public static string GetFieldName<TObject>(Expression<Func<TObject, object>> fieldExpression)
        {
            Contract.Requires<ArgumentNullException>(fieldExpression != null);
            Contract.Requires(TryGetFieldInfo(fieldExpression) != null);
            Contract.Ensures(Contract.Result<string>() != null);

            return GetFieldName((LambdaExpression)fieldExpression);
        }

        /// <summary>
        /// Finds field name via the field access expression.
        /// This overload is for static fields.
        /// </summary>
        /// <param name="fieldExpression">Field access expression.</param>
        public static string GetFieldName(Expression<Func<object>> fieldExpression)
        {
            Contract.Requires<ArgumentNullException>(fieldExpression != null);
            Contract.Requires(TryGetFieldInfo(fieldExpression) != null);
            Contract.Ensures(Contract.Result<string>() != null);

            return GetFieldName((LambdaExpression)fieldExpression);
        }

        /// <summary>
        /// Finds field name via the field access expression.
        /// This overload is for cases when you already have the expression object.
        /// </summary>
        /// <param name="fieldExpression">Field access expression.</param>
        public static string GetFieldName(LambdaExpression fieldExpression)
        {
            Contract.Requires<ArgumentNullException>(fieldExpression != null);
            Contract.Requires(TryGetFieldInfo(fieldExpression) != null);
            Contract.Ensures(Contract.Result<string>() != null);

            return GetFieldInfo(fieldExpression).Name;
        }

        private static Expression RemoveConverts(Expression expression)
        {
            Contract.Requires<ArgumentNullException>(expression != null);

            var effectiveExpression = expression;
            while (true)
            {
                switch (effectiveExpression.NodeType)
                {
                    case ExpressionType.Convert:
                    case ExpressionType.ConvertChecked:
                        effectiveExpression = ((UnaryExpression)effectiveExpression).Operand;
                        break;

                    default:
                        return effectiveExpression;
                }
            }
        }
    }
}
