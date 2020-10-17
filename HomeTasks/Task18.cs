using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Task18
    {
        /* Введите 2 целых числа. Проверьте, являются
        ли они оба положительными - используйте bool expretion.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > 0 && b > 0)
            {
                Console.WriteLine("Число {a} и {b} больше 0");
            }
            else
            {
                Console.WriteLine("Число {a} и {b} меньше 0");
            }
            Console.ReadKey();
        }
    }
}
