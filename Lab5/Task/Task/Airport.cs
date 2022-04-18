using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Task
{
    public enum Places
    {
        Nowhere,
        Paris,
        Moscow,
        Washington,
        Minsk,
        Tokyo
    }

    public class Airport
    {
        private List<Tarif> tarifs = new List<Tarif>();
        private List<Customer> customers = new List<Customer>();
        private Customer currentCust;
        private int totalCost = 0;

        public int TotalCost()
        {
            return totalCost;
        }

        public int CustomerCost()
        {
            return currentCust.GetCostOfTickets();
        }

        private Customer GetCustByName(string name, string surname)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Name == name)
                {
                    if (customers[i].Surname == surname)
                    {
                        return customers[i];
                    }
                }
            }
            return null;
        }

        public Tarif FindTarifByName(string place, int cost)
        {
            for (int i = 0; i < tarifs.Count; i++)
            {
                if (Tarif.GetPlaceByName(place) == tarifs[i].Place)
                {
                    if (cost == tarifs[i].Price)
                    {
                        return tarifs[i];
                    }
                }
            }
            return null;
        }

        public void BuyTarif(string place, int cost)
        {
            currentCust.BuyTarif(FindTarifByName(place, cost));
            totalCost += cost;
        }

        public void LogIn(string cust, string surname)
        {
            currentCust = GetCustByName(cust, surname);
        }

        public void LogOut()
        {
            currentCust = null;
        }

        public void AddTarif(string place, uint cost)
        {
            var tarif = new Tarif(place, cost);

            tarifs.Add(tarif);
        }

        public void AddCustomer(string name, string surname)
        {
            var cust = new Customer(name, surname);
            customers.Add(cust);
        }
    }
}
