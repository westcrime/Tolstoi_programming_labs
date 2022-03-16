using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2space;

namespace TestForTask2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mc = new Task2();

            Assert.AreEqual(mc.task2(2, -1), -1);
        }
    }

    [TestClass]

    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            var mc = new Task2();

            Assert.AreEqual(mc.task2(2, 0), 1);
        }
    }

    [TestClass]

    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod3()
        {
            var mc = new Task2();

            Assert.AreEqual(mc.task2(3, 0), 0);
        }
    }
}