using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Services
{
    public class DateService
    {

        static public int getDaysSpan(int day, int month, int year)
        {
            DateTime date1 = new DateTime(year, month, day);

           
            return Math.Abs((int)(DateTime.Now - date1).TotalDays);
        }
        static public DayOfWeek getDay(string date)
        {

            DateTime date1 = new DateTime();

            if (!DateTime.TryParse(date, out date1))
            {
                Console.WriteLine("некорректная дата!!!");
                return DayOfWeek.Monday;
            }
            else
            {
                return date1.DayOfWeek;
            }
        }
    }
}
