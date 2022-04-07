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
            Airport airport = Airport.Instance();
            airport.Name = "minsk";
            airport.Places = 192;
            airport.SoldTickets = 10;
            airport.setCostOfTicket(10);

            Assert.AreEqual(airport.CostOfSoldTickets(), 100);
        }
    }

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            Airport airport = Airport.Instance();
            airport.Name = "minsk";
            airport.Places = 192;
            airport.SoldTickets = 10;
            airport.setCostOfTicket(100);
            
            Assert.AreEqual(airport.CostOfSoldTickets(), 1000);
        }
    }

    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod3()
        {
            Airport airport = Airport.Instance("minsk", 100, 100, 192);

            Assert.AreEqual(airport.CostOfSoldTickets(), 10000);
        }
    }
}