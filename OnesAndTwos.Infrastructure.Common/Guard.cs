using System;
using OnesAndTwos.Infrastructure.Common.Extensions;

namespace OnesAndTwos.Infrastructure.Common
{
    public static class Guard
    {
        public static void Against<T>(bool predicate, string message, params object[] parameters) where T : Exception
        {
            if (predicate)
            {
                throw (Exception)Activator.CreateInstance(typeof(T), message.FormatWith(parameters));                
            }
        }
    }
}
