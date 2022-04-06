using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Airport airport = new Airport();
            airport.Name = "Minsk";
            airport.setCostOfTicket(10);
            airport.SoldTickets = 10;
            airport.Places = 100;

            Assert.AreEqual(airport.CostOfSoldTickets(), 100);
        }
    }

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            Airport airport = new Airport();
            airport.Name = "Minsk";
            airport.setCostOfTicket(100);
            airport.SoldTickets = 10;
            airport.Places = 100;

            Assert.AreEqual(airport.CostOfSoldTickets(), 1000);
        }
    }
}