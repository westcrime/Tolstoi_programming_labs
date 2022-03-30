using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;
using Task1.Services;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            Assert.AreEqual(Class1.f_x(0), 1);
        }
    }

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(Class2.function(21.0), Math.Log(21 + 0.5) + (Math.Exp(21) - Math.Exp(-1 * 21)));
            
        }
    }

    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(DateService.getDay("22.04.2022"), DayOfWeek.Friday);

        }
    }

    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(DateService.getDaysSpan(04, 04, 2022), 4);

        }
    }
}