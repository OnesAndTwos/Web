using Microsoft.Web.WebPages.OAuth;

namespace OnesAndTwos.Web.App_Start
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
            // you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

            OAuthWebSecurity.RegisterTwitterClient("SeJMwEOlANoCnTKUjQbmIw", "jSNCgS3L2IX9gnJONAaRmANrsjmgn0ulrMYmlrFI");
            OAuthWebSecurity.RegisterFacebookClient("149187848577119", "cabea19f8878efeeb09153eb76ab61d8");
        }
    }
}
