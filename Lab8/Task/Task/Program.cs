using Task;

Bank bank = new Bank();
ICustomerGift gift;
gift = new VipCustomerGift();
Customer dima = new Customer("Dima", 210, gift);
bank.Add(dima);
dima.GetGift();
/*gift = new VipCustomerGift();
bank.Add(new Customer("Misha", 500, new UsualCustomerGift()));*/
bank.Print();