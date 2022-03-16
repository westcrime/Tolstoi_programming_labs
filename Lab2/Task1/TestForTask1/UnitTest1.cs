using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1space;

namespace TestForTask1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mc = new Task1();

            Assert.IsTrue(mc.isEven(46));
        }
    }

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            var mc = new Task1();

            Assert.IsTrue(mc.isEven(-46));
        }
    }
}