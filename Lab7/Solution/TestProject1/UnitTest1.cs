using NUnit.Framework;
using Task;

namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var eq1 = new Equation(1, 1, 1);
        var eq2 = new Equation(1, 1, 0);
        eq2++;
        if (eq1 == eq2) Assert.Pass();
        Assert.Fail();
    }
    
    [Test]
    public void Test2()
    {
        var eq2 = new Equation(11, 11, 10);
        eq2 *= 2;
        if (new Equation(22, 22, 20) == eq2) Assert.Pass();
        Assert.Fail();
    }
}