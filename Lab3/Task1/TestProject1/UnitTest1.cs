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
            Assert.AreEqual(DateService.getDay("31.03.2022"), DayOfWeek.Thursday);

        }
    }

    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod4()
        {

            DateTime dateNow = new DateTime(DateTime.Now.AddDays(3).Year, DateTime.Now.AddDays(3).Month, DateTime.Now.AddDays(3).Day);

            Assert.AreEqual(DateService.getDaysSpan(dateNow.Day, dateNow.Month, dateNow.Year), 2);

        }
    }
}