using NUnit.Framework;

namespace nunit_test.Test
{
    [TestFixture]
    class MultiplyTest
    {
        [Test]
        public void multiply_should_work()
        {
            Assert.That(2 * 4, Is.EqualTo(8));
        }
    }
}
