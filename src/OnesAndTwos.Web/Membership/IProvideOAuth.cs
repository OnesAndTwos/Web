using System.Collections.Generic;
using DotNetOpenAuth.AspNet;
using Microsoft.Web.WebPages.OAuth;

namespace OnesAndTwos.Web.Membership
{
    public interface IProvideOAuth
    {
        void DisassociateAccount(string provider, string providerUserId);
        AuthenticationResult VerifyAuthentication(string action);
        bool Login(string provider, string providerUserId, bool rememberMe);
        void CreateAccount(string provider, string providerUserId, string name);
        AuthenticationClientData GetClientData(string provider);
        ICollection<AuthenticationClientData> RegisteredClientData { get; set; }
        void RequestAuthentication(string provider, string returnUrl);
    }
}