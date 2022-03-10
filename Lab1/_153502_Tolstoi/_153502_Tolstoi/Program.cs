namespace HelloWorld
{
    public class _153502_Tolstoi
    {
        static void Main(string[] args)
        {
            var mc = new _153502_Tolstoi();

            double x = 0, y = 0;

            System.Console.WriteLine("Enter 2 numbers");

            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            double answer = mc.task(x, y);

            System.Console.WriteLine("Answer is ");
            System.Console.WriteLine(answer);
        }

        public double task(double a, double b)
        {
            return a / b;
        }
    }
}
