using NUnit.Framework;

namespace Microservice.Second.UnitTests
{
    public class DummyTest2
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Dummy_Always_Pass()
        {
            Assert.Pass();
        }
    }
}
