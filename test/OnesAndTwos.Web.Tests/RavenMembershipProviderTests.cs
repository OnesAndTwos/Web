using NUnit.Framework;
using OnesAndTwos.Web.Membership;

namespace OnesAndTwos.Web.Tests
{
    [TestFixture]
    public class RavenMembershipProviderTests_when_logging_in : IUserStore
    {
        [Test]
        public void will_return_false_if_user_doesnt_exist()
        {
            var provider = new RavenMembershipProvider(this, null);

            var login = provider.Login("Username", "Password", false);

            Assert.That(login, Is.False);
        }
    }
}
