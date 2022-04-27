namespace ConsoleApp1;

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

    public abstract String GetRecipe();
    public virtual String Drink()
    {
        return new String("Surp, surp, surp, yummy!");
    }
    public String Spilled()
    {
        return new string("F#ck, I have just spilled my cocktail!");
    }
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
    public override String GetRecipe()
    {
        return new string("Secret");
    }

    public override String Drink()
    {
        return new string("YOU DIED");
    }
}

public class Mochito : AlcoholCocktail
{
    public override String GetRecipe()
    {
        return new String("Mochito is made of rome, lime, sugar, soda and mint.");
    }

    public override String Drink()
    {
        return new String("No, it is unhealthy!");
    }

    public new String Spilled()
    {
        return new String("Nevermind, will be healthier");
    }

}

public class BananaMilk : Cocktail
{
    public override String GetRecipe()
    {
        return new String("Banana-Milk is made of milk, banana, sugar and ice cream");
    }
}
