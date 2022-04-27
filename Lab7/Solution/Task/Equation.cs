namespace Task;

public class Equation
{
    private int a;
    private int b;
    private int c;

    public Equation()
    {
        A = 0;
        B = 0;
        C = 0;
    }

    public Equation(int a, int b, int c)
    {
        A = a;
        B = b;
        C = c;
    }

    public void GetSolutions()
    {
        var d = (int) Math.Pow(b, 2) - 4 * a * c;

        if (d < 0)
        {
            Console.WriteLine("This equation does not have solutions!");
            return;
        }

        if (d == 0)
        {
            var solution = -1 * (b / (2.0 * a));
            Console.WriteLine($"The solution is {solution}.");
            return;
        }

        var solution1 = (-b + Math.Sqrt(d)) / (2 * a);
        var solution2 = (-b - Math.Sqrt(d)) / (2 * a);

        Console.WriteLine($"The solutions are {solution1} and {solution2}.");
    }

    public int A
    {
        get => a;
        private set => a = value;
    }

    public int B
    {
        get => b;
        private set => b = value;
    }

    public int C
    {
        get => c;
        private set => c = value;
    }

    // Дальше перегрузка операторов
    
    public static Equation operator +(Equation eq, int value)
    {
        return new Equation(eq.A, eq.B, eq.C + value);
    }

    public static Equation operator -(Equation eq, int value)
    {
        return new Equation(eq.A, eq.B, eq.C - value);
    }

    public static Equation operator +(Equation eq1, Equation eq2)
    {
        return new Equation(eq1.A + eq2.A, eq1.B + eq2.B, eq1.C + eq2.C);
    }
    
    public static Equation operator -(Equation eq1, Equation eq2)
    {
        return new Equation(eq1.A - eq2.A, eq1.B - eq2.B, eq1.C - eq2.C);
    }
    
    public static Equation operator ++(Equation eq)
    {
        return new Equation(eq.A, eq.B, eq.C + 1);
    }

    public static Equation operator --(Equation eq)
    {
        return new Equation(eq.A, eq.B, eq.C - 1);
    }

    public static implicit operator Equation(int a)
    {
        return new Equation(a, 0, 0);
    }
    public static Equation operator *(Equation eq, int value)
    {
        return new Equation(eq.A * value, eq.B * value, eq.C * value);
    }

    public static Equation operator /(Equation eq, int value)
    {
        return new Equation(eq.A / value, eq.B / value, eq.C / value);
    }

    public static bool operator false(Equation eq)
    {
        var d = (int) Math.Pow(eq.B, 2) - 4 * eq.A * eq.C;
        return d < 0;
    }
    
    public static bool operator true(Equation eq)
    {
        var d = (int) Math.Pow(eq.B, 2) - 4 * eq.A * eq.C;
        return d >= 0;
    }

    public static bool operator !(Equation eq)
    {
        var d = (int) Math.Pow(eq.B, 2) - 4 * eq.A * eq.C;
        return !(d >= 0);
    }

    public static bool operator ==(Equation eq1, Equation eq2)
    {
        return (eq1.A == eq2.A && eq1.B == eq2.B && eq1.C == eq2.C);
    }
    
    public static bool operator !=(Equation eq1, Equation eq2)
    {
        return (eq1.A != eq2.A || eq1.B != eq2.B || eq1.C != eq2.C);
    }
}