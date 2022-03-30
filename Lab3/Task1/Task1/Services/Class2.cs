//Вариант 8. Выполнил Толстой Дмитрий

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Services
{
    public class Class2
    {
        static public double function(double z)
        {
            double x;

            if (z < -1)
            {
                x = (-1 * z) / 3;
                Console.WriteLine("Мы пошли по ветке z < -1\n");
            }
            else
            {
                x = Math.Abs(z);
                Console.WriteLine("Мы пошли по ветке z >= -1\n");
            }

            double answer =  Math.Log(x + 0.5) + (Math.Exp(x) - Math.Exp(-1 * x));

            Console.WriteLine("ответ = {0}", answer);

            return answer;
        }
    }
}
