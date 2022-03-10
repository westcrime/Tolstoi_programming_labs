namespace HelloWorld
{
    class _153502_Tolstoi
    {
        static void Main(string[] args)
        {
            double x = 0, y = 0;

            System.Console.WriteLine("Enter 2 numbers");

            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            double answer = x / y;

            System.Console.WriteLine("Answer is ");
            System.Console.WriteLine(answer);
        }
    }
}
