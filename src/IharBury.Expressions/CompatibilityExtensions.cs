﻿using System;
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

#if NET40
            return type.BaseType;
#else
            return type.GetTypeInfo().BaseType;
#endif
        }

        internal static IEnumerable<PropertyInfo> GetDeclaredProperties(this Type type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

#if NET40
            return (IEnumerable<PropertyInfo>)type.GetProperties(BindingFlags.DeclaredOnly | 
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

#if NET40
            return type.IsGenericType && !type.IsGenericTypeDefinition;
#else
            return type.IsConstructedGenericType;
#endif
        }
    }
}
