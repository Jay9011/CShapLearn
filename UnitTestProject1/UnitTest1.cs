using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMVCWeb.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldSayHello()
        {
            var sw = new Welcome();
            Assert.AreEqual("Hello World", sw.SayHello());
        }
    }
}