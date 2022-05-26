using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Customer
    {
        public string Name { get; set; }
        public bool GiftIsTaken { get; set; }
        public int Contribution { get; set; }
        public ICustomerGift CustomerGift { get; set; }

        public Customer(string name, int contribution, ICustomerGift customerGift)
        {
            GiftIsTaken = false;
            Name = name;
            Contribution = contribution;
            CustomerGift = customerGift;
        }

        public void GetGift()
        {
            CustomerGift.TakeGift(this);
        }
    }


    interface ICustomerGift
    {
        void TakeGift(Customer cust);
        int GetGiftSum();
    }

    class CustomerGift : ICustomerGift
    {
        public virtual int Gift { get; set; }
        public int GetGiftSum()
        {
            return Gift;
        }
        public void TakeGift(Customer cust)
        {
            if (cust.GiftIsTaken == false)
                cust.Contribution = cust.Contribution + Gift;
            cust.GiftIsTaken = true;
        }
    }

    class VipCustomerGift : CustomerGift
    {
        public VipCustomerGift()
        {
            Gift = 100;
        }
    }

    class UsualCustomerGift : CustomerGift
    {
        public UsualCustomerGift()
        {
            Gift = 10;
        }
    }
}