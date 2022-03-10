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
            var mc = new _153502_Tolstoi();

            int a = 6, b = 3;

            double ans = mc.task(a, b);

            Assert.AreEqual(2, ans);
        }
    }

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            var mc = new _153502_Tolstoi();

            int a = 81, b = 3;

            double ans = mc.task(a, b);

            Assert.AreEqual(27, ans);
        }
    }
}