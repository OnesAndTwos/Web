namespace OnesAndTwos.Web.Membership
{
    public interface IEncode
    {
        string SerializeUserId(string provider, string providerUserId);
        bool TryDeserializeProviderUserId(string externalLoginData, out string provider, out string providerUserId);
    }
}