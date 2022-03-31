//Лабораторная работа номер 1. Задание номер 2. Выполнил Толстой Дмитрий. Вариант 2

namespace Task2space;
public class Task2
{
    static void Main(string[] args)
    {
        var mc = new Task2();

        int x = 0, y = 0;

        Console.WriteLine("Enter the x.\n");

        while (!int.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Invalid input.\n");
        }

        Console.WriteLine("Enter the y.\n");

        while (!int.TryParse(Console.ReadLine(), out y))
        {
            Console.WriteLine("Invalid input.\n");
        }

        int answer = mc.task2(x, y);

        switch (answer)
        {
            case 0:
                {
                    Console.WriteLine("On border\n");
                    break;
                }
            case 1:
                {
                    Console.WriteLine("Yes\n");
                    break;
                }
            case -1:
                {
                    Console.WriteLine("No\n");
                    break;
                }
        }
    }

    public int task2(int x, int y)
    {
        if (y < 0)
        {
            return -1;
        }
        else
        {
            int vector = x * x + y * y;

            if (vector < 9)
            {
                return 1;
            }
            else
            {
                if (vector > 9)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

