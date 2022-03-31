using Task1;
using Task1.Services;


namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Задание номер 2. Введите чсило \n");

            double z;

            while (!double.TryParse(Console.ReadLine(), out z))
            {
                Console.WriteLine("некорректное значение\n");
            }

            Class2.function(z);

            
        }
    }
}