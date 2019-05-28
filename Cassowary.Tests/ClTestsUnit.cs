using NUnit.Framework;

namespace Cassowary.Tests
{
    [TestFixture]
    public class ClTestsUnit
    {
        [Test]
        public void Simple1()
        {
            Assert.IsTrue(ClTests.Simple1());
        }

        [Test]
        public void JustStay1()
        {
            Assert.IsTrue(ClTests.JustStay1());
        }

        [Test]
        public void AddDelete1()
        {
            Assert.IsTrue(ClTests.AddDelete1());
        }

        [Test]
        public void AddDelete2()
        {
            Assert.IsTrue(ClTests.AddDelete2());
        }

        [Test]
        public void Casso1()
        {
            Assert.IsTrue(ClTests.Casso1());
        }

        [Test]
        public void Inconsistent1o1()
        {
            Assert.IsTrue(ClTests.Inconsistent1());
        }

        [Test]
        public void Inconsistent2()
        {
            Assert.IsTrue(ClTests.Inconsistent2());
        }

        [Test]
        public void Inconsistent3()
        {
            Assert.IsTrue(ClTests.Inconsistent3());
        }

        [Test]
        public void Multiedit()
        {
            Assert.IsTrue(ClTests.Multiedit());
        }
    }
}
