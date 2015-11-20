using System;
using System.Collections.Generic;
using System.Reflection;

namespace IharBury.Expressions
{
    internal static class CompatibilityExtensions
    {
        internal static Type GetBaseType(this Type type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

#if NET35 || NET35_CLIENT || NET37_CF || NET40 || NET40_CLIENT
            return type.BaseType;
#else
            return type.GetTypeInfo().BaseType;
#endif
        }

        internal static IEnumerable<PropertyInfo> GetDeclaredProperties(this Type type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

#if NET35 || NET35_CLIENT || NET37_CF || NET40 || NET40_CLIENT
            return type.GetProperties(BindingFlags.DeclaredOnly | 
                BindingFlags.Instance | 
                BindingFlags.Static | 
                BindingFlags.Public | 
                BindingFlags.NonPublic);
#else
            return type.GetTypeInfo().DeclaredProperties;
#endif
        }

        internal static bool GetIsConstructedGenericType(this Type type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

#if NET35 || NET35_CLIENT || NET37_CF || NET40 || NET40_CLIENT
            return type.IsGenericType && !type.IsGenericTypeDefinition;
#else
            return type.IsConstructedGenericType;
#endif
        }
    }
}
