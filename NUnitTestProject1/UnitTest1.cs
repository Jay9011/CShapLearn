using NUnit.Framework;
using TestMVCWeb.Models;

namespace NUnitTestProject1
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("Hello World", new Welcome().SayHello());
        }
    }
}