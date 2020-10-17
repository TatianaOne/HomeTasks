using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Task27
    {
        /*Прочитайте double число r и рассчитайте длину (l=2*pi*r),
        площадь (S=pi*r*r) и объем (4/3 * pi * r * r * r) круга заданного r.*/
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите радиус круга: ");
                double r = Convert.ToDouble(Console.ReadLine());

                double perimeter = 2 * Math.PI * r;
                double area = Math.PI * r * r;
                double volume = 4 / 3 * Math.PI * r * r * r;

                Console.WriteLine($"Периметр круга равен {perimeter}");
                Console.WriteLine($"Площадь круга равна {area}");
                Console.WriteLine($"Объем круга равен {volume}");
                Console.ReadKey();
            }
        }
    }
}
