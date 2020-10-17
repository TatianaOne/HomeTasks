using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Task21
    {
        /*Определить целочисленную переменную а. Прочитайте значение a
 из консоли и рассчитайте площадь и периметр квадрата с длиной a. Вывод полученных результатов.*/
        static void Main()
        {
            Console.WriteLine("Введите значение: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int square = a * a;
            Console.WriteLine($"Площадь квадрата равна: {square}");

            int perimeter = a * 4;
            Console.WriteLine($"Периметр квадрата равен: {perimeter}");

            Console.ReadKey();
        }
    }
}
