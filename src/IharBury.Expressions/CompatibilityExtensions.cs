using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace IharBury.Expressions
{
    internal static class CompatibilityExtensions
    {
        public static Type GetBaseType(this Type type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

#if NET35 || NET35_CLIENT || NET40 || NET40_CLIENT
            return type.BaseType;
#else
            return type.GetTypeInfo().BaseType;
#endif
        }

        public static IEnumerable<PropertyInfo> GetDeclaredProperties(this Type type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

#if NET35 || NET35_CLIENT || NET40 || NET40_CLIENT
            return type.GetProperties(BindingFlags.DeclaredOnly | 
                BindingFlags.Instance | 
                BindingFlags.Static | 
                BindingFlags.Public | 
                BindingFlags.NonPublic);
#else
            return type.GetTypeInfo().DeclaredProperties;
#endif
        }

        public static bool GetIsConstructedGenericType(this Type type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

#if NET35 || NET35_CLIENT || NET40 || NET40_CLIENT
            return type.IsGenericType && !type.IsGenericTypeDefinition;
#else
            return type.IsConstructedGenericType;
#endif
        }

        public static MethodInfo FindMethod(this Type type, string name, params Type[] parameterTypes)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException($"string.{nameof(string.IsNullOrEmpty)}({nameof(name)}name)", nameof(name));
            if (parameterTypes == null)
                throw new ArgumentNullException(nameof(parameterTypes));

            return type
#if NET35 || NET35_CLIENT || NET40 || NET40_CLIENT
                .GetMethods()
                .Where(method => method.Name == name)
#else
                .GetTypeInfo()
                .GetDeclaredMethods(name)
#endif
                .SingleOrDefault(method =>
                    method.GetParameters().Select(parameter => parameter.ParameterType).SequenceEqual(parameterTypes));
        }

        public static MethodInfo GetGetMethod(this PropertyInfo property)
        {
            if (property == null)
                throw new ArgumentNullException(nameof(property));

#if NET35 || NET35_CLIENT || NET40 || NET40_CLIENT
            return property.GetGetMethod();
#else
            return property.GetMethod;
#endif
        }

        public static IEnumerable<LambdaExpression> CovariantCast<T>(this IEnumerable<Expression<T>> collection)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

#if NET35 || NET35_CLIENT
            return collection.Cast<LambdaExpression>();
#else
            return collection;
#endif
        }

        public static LambdaExpression CreateLambda(this Expression body, IEnumerable<ParameterExpression> parameters)
        {
            if (body == null)
                throw new ArgumentNullException(nameof(body));

            return Expression.Lambda(
                body,
#if NET35 || NET35_CLIENT
                parameters.ToArray());
#else
                parameters);
#endif
        }

        public static LambdaExpression Update(
            this LambdaExpression expression,
            Expression body,
            IEnumerable<ParameterExpression> parameters)
        {
            if (expression == null)
                throw new ArgumentNullException(nameof(expression));

#if NET35 || NET35_CLIENT
            return Expression.Lambda(expression.Type, body, parameters);
#else
            return expression.Update(body, parameters);
#endif
        }
    }
}
