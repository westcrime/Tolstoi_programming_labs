using Task1;
using Task1.Services;


namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите 2 значения a и b\n");
            double a, b;
            while(!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("некорректное значение\n");
            }   
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("некорректное значение\n");
            }

            Console.WriteLine("Первый ответ = {0}\n", Class1.f_x(a));
            Console.WriteLine("Второй ответ = {0}\n", Class1.f_x(b));

            if (Class1.f_x(a) > Class1.f_x(b))
            {
                Console.WriteLine("первый ответ больше \n");
            }
            else
            {
                if (Class1.f_x(a) < Class1.f_x(b))
                {
                    Console.WriteLine("второй ответ больше \n");
                }
                else
                {
                    Console.WriteLine("они равны \n");
                }
            }

            Console.WriteLine("Задание номер 2. Введите чсило \n");

            double z;

            while (!double.TryParse(Console.ReadLine(), out z))
            {
                Console.WriteLine("некорректное значение\n");
            }

            Class2.function(z);

            Console.WriteLine("Переход к 3 заданию...\n Введите дату");

            string date = Console.ReadLine();

            Console.WriteLine("День недели этой даты - {0}", DateService.getDay(date).ToString());

            Console.WriteLine("Введите дату до которой досчитать дни \n");

            string newDate = Console.ReadLine();

            DateTime _date = new DateTime();

            while (!(DateTime.TryParse(newDate, out _date)))
            {
                Console.WriteLine("Неверная дата");
            }
                Console.WriteLine("промежуток - {0} ", DateService.getDaysSpan(_date.Day, _date.Month, _date.Year).ToString());
        }
    }
}