using System;
using System.Collections.Generic;
using System.Linq;

namespace OnesAndTwos.Infrastructure.Common.Extensions
{
    public static class EnumExtensions
    {
        public static string GetAttributeString<T>(this Enum e, Func<T, string> getter) where T : Attribute
        {
            var attribute = e.GetType().GetMember(e.ToString())[0].GetCustomAttributes(typeof(T), false).Cast<T>().SingleOrDefault();

            return attribute == null ? null : getter(attribute);
        }

        public static IEnumerable<T> All<T>() where T : struct, IConvertible
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
    }
}
