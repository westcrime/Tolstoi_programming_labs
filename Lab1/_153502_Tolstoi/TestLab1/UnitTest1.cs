using Microsoft.VisualStudio.TestTools.UnitTesting;

using HelloWorld;

namespace TestLab1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 6, b = 3;

            double ans = a / b;

            Assert.AreEqual(2, ans);
        }
    }
}