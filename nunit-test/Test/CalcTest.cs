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
    }
}
