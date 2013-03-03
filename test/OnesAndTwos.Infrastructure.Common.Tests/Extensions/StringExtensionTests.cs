using NUnit.Framework;
using OnesAndTwos.Infrastructure.Common.Extensions;

namespace OnesAndTwos.Infrastructure.Common.Tests.Extensions
{
    [TestFixture]
    public class StringExtensionTests
    {
        [Test]
        public void formats_string_correctly()
        {
            Assert.That("Original {0} {1}".FormatWith("Parameter 1", "Parameter 2"),
                Is.EqualTo("Original Parameter 1 Parameter 2"));
        }
    }
}
