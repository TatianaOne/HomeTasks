using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Task5
    {
        /*Знайти суму цифр введеного цілого числа*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int y = x % 10 + x % 100 / 10 + x % 1000 / 100;
            Console.WriteLine($"Сумма цифр числа равна: {y}");
            Console.ReadKey();
        }
    }
}
