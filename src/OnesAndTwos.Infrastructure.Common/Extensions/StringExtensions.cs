namespace OnesAndTwos.Infrastructure.Common.Extensions
{
    public static class StringExtensions
    {
         public static string FormatWith(this string unformattedString, params object[] parameters)
         {
             return string.Format(unformattedString, parameters);
         }
    }
}