using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Customer
    {
        private List<Tarif> boughtTarifs = new List<Tarif>();
        private string name;
        private string surname;

        public int GetCostOfTickets()
        {
            int count = 0;
            for (int i = 0; i < boughtTarifs.Count; i++)
            {
                count += (int)boughtTarifs[i].Price;
            }
            return count;
        }

        public void BuyTarif(Tarif tarif)
        {
            boughtTarifs.Add(tarif);
        }

        public Customer(string Name, string Surname)
        {
            name = Name;
            surname = Surname;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public List<Tarif> BoughtTarifs
        {
            get { return boughtTarifs; }
        }
    }
}
