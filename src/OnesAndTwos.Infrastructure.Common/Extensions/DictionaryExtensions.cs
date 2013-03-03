using System;
using System.Collections;

namespace OnesAndTwos.Infrastructure.Common.Extensions
{
    public static class DictionaryExtensions
    {
        public static TValue LazyLoad<TKey, TValue>(this IDictionary dictionary, TKey key, Func<TValue> loader) where TValue : class
        {
            var result = dictionary[key] as TValue;

            if (result == null)
            {
                result = loader();
                dictionary[key] = result;
            }

            return result;
        }
    }
}
