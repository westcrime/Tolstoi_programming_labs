using ConsoleApp1;

Mochito mochito = new Mochito();
BananaMilk bananaMilk = new BananaMilk();
Console.WriteLine("Mochito: ");
Console.WriteLine(mochito.GetRecipe());
Console.WriteLine("Let's drink.");
Console.WriteLine(mochito.Drink());
Console.WriteLine(mochito.Spilled());
Console.WriteLine("Banana-milk: ");
Console.WriteLine(bananaMilk.GetRecipe());
Console.WriteLine("Let's drink.");
Console.WriteLine(bananaMilk.Drink());
Console.WriteLine(bananaMilk.Spilled());