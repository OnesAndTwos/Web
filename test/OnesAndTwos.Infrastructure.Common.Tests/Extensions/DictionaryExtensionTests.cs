using System.Collections.Generic;
using NUnit.Framework;
using OnesAndTwos.Infrastructure.Common.Extensions;

namespace OnesAndTwos.Infrastructure.Common.Tests.Extensions
{
    [TestFixture]
    public class DictionaryExtensionTests
    {
        [Test]
        public void lazy_loads_correctly()
        {
            var lazyLoadedObject = new object();
            var differentObject = new object();

            var dictionary = new Dictionary<string, object>();

            var firstCall = dictionary.LazyLoad("Test.Key", () => lazyLoadedObject);

            Assert.That(firstCall, Is.EqualTo(lazyLoadedObject));

            var secondCall = dictionary.LazyLoad("Test.Key", () => differentObject);

            Assert.That(secondCall, Is.EqualTo(lazyLoadedObject));
        }
    }
}
