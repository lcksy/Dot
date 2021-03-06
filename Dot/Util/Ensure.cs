﻿using System;
using System.Collections.Generic;
using System.Linq;
using Dot.Extension;

namespace Dot.Util
{
    public static class Ensure
    {
        public static void NotNull<T>(T param, string paramName)
            where T : class
        {
            if (param == null)
                throw new ArgumentNullException(paramName, paramName + " can not be null.");
        }

        public static void NotNullOrEmpty(string param, string paramName)
        {
            if (string.IsNullOrEmpty(param))
                throw new ArgumentNullException(paramName, paramName + " can not be null or empty.");
        }

        public static void NotNullOrEmpty<T>(IEnumerable<T> items, string paramName)
        {
            if (items == null || !items.Any())
                throw new ArgumentNullException(paramName, paramName + " can not be null or empty.");
        }

        public static void Greater<T>(T param, T comparand, string paramName)
            where T : IComparable<T>
        {
            if (!param.GreaterThan(comparand))
                throw new ArgumentException(paramName, "{0}[{1}] must greater than {2}".FormatWith(paramName, param, comparand));
        }

        public static void GreaterOrEqual<T>(T param, T comparand, string paramName)
            where T : IComparable<T>
        {
            if (!param.GreaterOrEqualThan(comparand))
                throw new ArgumentException(paramName, "{0}[{1}] must greater or equal than {2}".FormatWith(paramName, param, comparand));
        }

        public static void Smaller<T>(T param, T comparand, string paramName)
            where T : IComparable<T>
        {
            if (!param.SmallerThan(comparand))
                throw new ArgumentException(paramName, "{0}[{1}] must smaller than {2}".FormatWith(paramName, param, comparand));
        }

        public static void SmallerOrEqual<T>(T param, T comparand, string paramName)
            where T : IComparable<T>
        {
            if (!param.SmallerOrEqualThan(comparand))
                throw new ArgumentException(paramName, "{0}[{1}] must smaller or equal than {2}".FormatWith(paramName, param, comparand));
        }

        public static void EqualThan<T>(T expected, T actual, string paramName)
        {
            if (!object.Equals(expected, actual))
                throw new ArgumentException(paramName, "{0} must be type of {1}, current type is {2}".FormatWith(paramName, expected, actual));
        }

        public static void True(bool isTrue, string paramName, string message)
        {
            if (!isTrue)
                throw new ArgumentException(paramName, message);                                                                                                                                                                                                                                                                                                                                                                                                                          
        }

        public static void True(bool isTrue, string message)
        {
            if (!isTrue)
                throw new Exception(message);
        }
    }
}