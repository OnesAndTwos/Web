using System;
using NUnit.Framework;

namespace OnesAndTwos.Infrastructure.Common.Tests
{
    public class GuardTests
    {
        [Test]
        public void will_throw_expected_exception_when_predicate_matches()
        {
            Assert.Throws<TestException>(() => Guard.Against<TestException>(true, "ExceptionMessaage"));
        }

        [Test]
        public void will_not_throw_exception_when_predicate_doesnt_match()
        {
            Assert.DoesNotThrow(() => Guard.Against<TestException>(false, "ExceptionMessaage"));
        }

        // ReSharper disable ClassNeverInstantiated.Local
        class TestException : Exception
        {
            public TestException(string message) : base(message)  { }
        }
        // ReSharper restore ClassNeverInstantiated.Local
    }
}
