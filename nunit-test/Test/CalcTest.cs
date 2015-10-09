using NUnit.Framework;

namespace nunit_test.Test
{
    [TestFixture]
    class CalcTest
    {
        [Test]
        public void minus_should_work()
        {
            Assert.That(4 - 2, Is.EqualTo(2));
        }

        [Test]
        public void plus_should_work()
        {
            Assert.That(4 + 2, Is.EqualTo(6));
        }

        [Test]
        public void minus_should_not_work()
        {
            Assert.That(4 - 2, Is.GreaterThan(0));
        }
    }
}
