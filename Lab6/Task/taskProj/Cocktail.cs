namespace taskProj;

public abstract class Cocktail
{
    protected int Size { get; set; }
    protected int Cost { get; set; }

    public Cocktail()
    {
        Size = 0;
        Cost = 0;
    }
    
    public Cocktail(int cost, int size)
    {
        Size = size;
        Cost = cost;
    }

    public abstract void GetRecipe();
    public virtual void Drink() => Console.WriteLine("Surp, surp, surp, yummy!");
    public void Spilled() => Console.WriteLine("F#ck, I have just spilled my cocktail!");
}

public abstract class AlcoholCocktail : Cocktail
{
    private int AlcoholPercentage { get; }

    public AlcoholCocktail() :
        base(0, 0)
    {
        AlcoholPercentage = 0;
    }

    public AlcoholCocktail(int cost, int size, int alcoholPercentage)
    {
        base.Size = size;
        base.Cost = cost;
        AlcoholPercentage = alcoholPercentage;
    }
}

public sealed class DeadCocktail : Cocktail
{
    public override void GetRecipe()
    {
        Console.WriteLine("Secret");
    }

    public override void Drink()
    {
        Console.WriteLine("YOU DIED");
    }
}

public class Mochito : AlcoholCocktail
{
    public override void GetRecipe()
    {
        Console.WriteLine("Mochito is made of rome, lime, sugar, soda and mint.");
    }

    public override void Drink()
    {
        Console.WriteLine("No, it is unhealthy!");
    }

    public new void Spilled() => Console.WriteLine("Nevermind, will be healthier");
}

public class BananaMilk : Cocktail
{
    public override void GetRecipe()
    {
        Console.WriteLine("Banana-Milk is made of milk, banana, sugar and ice cream");
    }
}
