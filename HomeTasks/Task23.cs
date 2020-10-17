using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Task23
    {
        /*прочитать 3 целых числа и записать максимальное и минимальное из них.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите третье число: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double min, max;

            if (a > b)
            {
                if (a > c)
                {
                    max = a;
                }
                else max = c;
            }
            else if (b > c)
            {
                max = b;
            }
            else max = c;

            if (a < b)
            {
                if (a < c)
                {
                    min = a;
                }
                else min = c;
            }
            else if (b < c)
            {
                min = b;
            }
            else min = c;

            Console.WriteLine($"Максимальное число:" + max);
            Console.WriteLine($"Минимальное число:" + min);

            Console.ReadKey();
        }
    }
}
