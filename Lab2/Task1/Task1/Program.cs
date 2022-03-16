//Лабораторная работа номер 1. Задание номер 1. Выполнил Толстой Дмитрий. Вариант 1

namespace Task1space;
public class Task1
{
    static void Main(string[] args)
    {
        var mc = new Task1();

        bool firstTime = true;

        while (true)
        {
            char c;

            if (firstTime)
            {
                Console.WriteLine("Check the number or not? (Y - yes, N - no).\n");


                firstTime = false;
            }
            else
            {
                Console.WriteLine("Continue or not? (Y - yes, N - no).\n");
            }
            String str = Console.ReadLine();

            c = str[0];

            if (c != 'Y' && c != 'N' && c != 'y' && c != 'n')
            {
                Console.WriteLine("Invalid input! Please try again.\n");
                continue;
            }
            else
            {
                switch (c)
                {
                    case 'y':
                        {
                            int x = 0;

                            Console.WriteLine("Enter the int number");
                            while (!int.TryParse(Console.ReadLine(), out x))
                            {
                                Console.WriteLine("Invalid input.\n");
                            }
                            if (mc.isEven(x))
                            {
                                Console.WriteLine("This number is even.\n");
                            }
                            else
                            {
                                Console.WriteLine("This number is not even.\n");
                            }
                            break;
                        }
                    case 'Y':
                        {
                            int x = 0;

                            Console.WriteLine("Enter the int number");
                            while (!int.TryParse(Console.ReadLine(), out x))
                            {
                                Console.WriteLine("Invalid input.\n");
                            }
                            if (mc.isEven(x))
                            {
                                Console.WriteLine("This number is even.\n");
                            }
                            else
                            {
                                Console.WriteLine("This number is not even.\n");
                            }
                            break;
                        }
                    default:
                        {
                            return;
                        }
                }
            }
        }
    }

    public bool isEven(int number)
    {
        return (number % 2 == 0);
    }
}

