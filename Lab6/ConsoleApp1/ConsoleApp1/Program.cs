using ConsoleApp1;

Mochito mochito = new Mochito();
BananaMilk bananaMilk = new BananaMilk();
Console.WriteLine("Mochito: ");
mochito.GetRecipe();
Console.WriteLine("Let's drink.");
mochito.Drink();
mochito.Spilled();
Console.WriteLine("Banana-milk: ");
bananaMilk.GetRecipe();
Console.WriteLine("Let's drink.");
bananaMilk.Drink();
bananaMilk.Spilled();