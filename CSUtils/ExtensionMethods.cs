using System.Collections.Generic;
using System;
using System.Collections;
using System.Linq;

namespace CSUtils.ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static bool IsUnique<T>(this IEnumerable<T> list)
        {
            var diffChecker = new HashSet<T>();
            return list.All(diffChecker.Add);
        }

        public static bool IsNullOrEmpty(this ICollection list)
        {
            return list == null || list.Count <= 0;
        }
    }
}
