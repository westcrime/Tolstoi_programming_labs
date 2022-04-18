using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Airport airport = new Airport();

            airport.AddTarif("Minsk", 100);
            airport.AddTarif("Tokyo", 500);
            airport.AddTarif("Washington", 100);

            airport.AddCustomer("Dima", "Tolstoy");
            airport.AddCustomer("Ivan", "Ivanov");

            airport.LogIn("Dima", "Tolstoy");
            airport.BuyTarif("Washington", 100);
            airport.BuyTarif("Tokyo", 500);
            airport.BuyTarif("Minsk", 100);
            Assert.AreEqual(airport.CustomerCost(), 700);
            airport.LogOut();
        }

        [TestMethod]
        public void TestMethod2()
        {
            Airport airport = new Airport();

            airport.AddTarif("Minsk", 0);
            airport.AddTarif("Tokyo", 0);
            airport.AddTarif("Washington", 0);

            airport.AddCustomer("Dima", "Tolstoy");
            airport.AddCustomer("Ivan", "Ivanov");

            airport.LogIn("Dima", "Tolstoy");
            airport.BuyTarif("Washington", 0);
            airport.BuyTarif("Tokyo", 0);
            airport.BuyTarif("Minsk", 0);
            Assert.AreEqual(airport.CustomerCost(), 0);
            airport.LogOut();
        }


        [TestMethod]
        public void TestMethod3()
        {
            Airport airport = new Airport();

            airport.AddTarif("Minsk", 900);
            airport.AddTarif("Tokyo",900);
            airport.AddTarif("Washington", 900);

            airport.AddCustomer("Dima", "Tolstoy");
            airport.AddCustomer("Ivan", "Ivanov");

            airport.LogIn("Dima", "Tolstoy");
            airport.BuyTarif("Washington", 900);
            airport.BuyTarif("Tokyo", 900);
            airport.BuyTarif("Minsk", 900);          
            airport.LogOut();

            airport.LogIn("Ivan", "Ivanov");
            airport.BuyTarif("Washington", 900);
            airport.BuyTarif("Tokyo", 900);
            airport.BuyTarif("Minsk", 900);
            airport.BuyTarif("Minsk", 900);
            airport.LogOut();

            Assert.AreEqual(airport.TotalCost(), 6300);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Airport airport = new Airport();

            airport.AddTarif("Minsk", 900);
            airport.AddTarif("Tokyo", 900);
            airport.AddTarif("Washington", 900);

            airport.AddCustomer("Dima", "Tolstoy");
            airport.AddCustomer("Ivan", "Ivanov");

            airport.LogIn("Dima", "Tolstoy");
            airport.BuyTarif("Washington", 900);
            airport.BuyTarif("Tokyo", 900);
            airport.BuyTarif("Minsk", 900);
            airport.LogOut();

            airport.LogIn("Ivan", "Ivanov");
            airport.BuyTarif("Washington", 900);
            airport.BuyTarif("Tokyo", 900);
            airport.BuyTarif("Minsk", 900);
            airport.BuyTarif("Minsk", 900);
            airport.BuyTarif("Minsk", 900);
            airport.BuyTarif("Minsk", 900);
            airport.LogOut();

            Assert.AreEqual(airport.TotalCost(), 8100);
        }
    }
}