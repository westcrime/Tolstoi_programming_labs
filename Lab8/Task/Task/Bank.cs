using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task
{
    class Bank
    {
        private List<Customer> ?list;
        public void Print()
        {
            if (list == null) return;
            foreach (Customer i in list)
            {
                Console.WriteLine("Customer {0} has {1} on his/her count, and {2} of it is special gift.", i.Name, i.Contribution, i.CustomerGift.GetGiftSum());
            }
        }

        public void Add(Customer cust)
        {
            if (list == null) list = new List<Customer>();
            list.Add(cust);
        }
    }
}
