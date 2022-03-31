using Task1;
using Task1.Services;


namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Переход к 3 заданию...\n Введите дату");

            string date = Console.ReadLine();

            Console.WriteLine("День недели этой даты - {0}", DateService.getDay(date).ToString());
        }
    }
}