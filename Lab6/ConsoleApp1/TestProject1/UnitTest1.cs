using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mochito = new Mochito();
            Assert.AreEqual(mochito.Spilled(), "Nevermind, will be healthier");
        }
    }

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            var mochito = new Mochito();
            Assert.AreEqual(mochito.Drink(), "No, it is unhealthy!");
        }
    }

    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod3()
        {
            var banana = new BananaMilk();
            Assert.AreEqual(banana.GetRecipe(), "Banana-Milk is made of milk, banana, sugar and ice cream");
        }
    }
}