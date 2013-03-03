using System;
using NUnit.Framework;
using OnesAndTwos.Infrastructure.Common.Extensions;

namespace OnesAndTwos.Infrastructure.Common.Tests.Extensions
{
    [TestFixture]
    public class EnumExtensionTests
    {
        [Test]
        public void returns_correct_string_from_enum_attribute()
        {
            Assert.That(TestEnum.First.GetAttributeString<ATestAttributeAttribute>(a => a.TestProperty), 
                Is.EqualTo("First Param"));

            Assert.That(TestEnum.Second.GetAttributeString<ATestAttributeAttribute>(a => a.TestProperty), 
                Is.EqualTo("Second Param"));

            Assert.That(TestEnum.NoAttribute.GetAttributeString<ATestAttributeAttribute>(a => a.TestProperty),
                Is.Null);
        }

        [Test]
        public void returns_all_enum_values()
        {
            Assert.That(EnumExtensions.All<TestEnum>(),
                        Is.EquivalentTo(new[] { TestEnum.First, TestEnum.Second, TestEnum.NoAttribute }));
        }

        enum TestEnum
        {
            [ATestAttribute("First Param")] First,
            [ATestAttribute("Second Param")] Second,
            NoAttribute
        }

        class ATestAttributeAttribute : Attribute
        {
            public ATestAttributeAttribute(string message)
            {
                TestProperty = message;
            }

            public string TestProperty { get; private set; }
        }
    }
}
