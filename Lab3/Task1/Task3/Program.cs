using Task1;
using Task1.Services;


namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            
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