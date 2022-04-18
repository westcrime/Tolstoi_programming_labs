using Task;

Airport airport = new Airport();

airport.AddTarif("Minsk", 1200);
airport.AddTarif("Tokyo", 5000);
airport.AddTarif("Washington", 200);

airport.AddCustomer("Dima", "Tolstoy");
airport.AddCustomer("Ivan", "Ivanov");

airport.LogIn("Dima", "Tolstoy");
airport.BuyTarif("Tokyo", 5000);
airport.LogOut();

airport.LogIn("Ivan", "Ivanov");
airport.BuyTarif("Washington", 200);
airport.BuyTarif("Minsk", 1200);
Console.WriteLine("Total wasted money of Ivan is {0}\n", airport.CustomerCost());
airport.LogOut();

Console.WriteLine("Total cost of sent tickets - {0}\n", airport.TotalCost());
