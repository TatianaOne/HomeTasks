using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Task1
    {
        /* Найти периметр треугольника, заданный координатами своих вершин.
        (Определить функцию для расчета длины отрезка по координатам вершин.)*/

        static void Main(string[] args)
        {
            double x1 = 3.0;
            double x2 = 8.0;
            double x3 = 12.0;
            double y1 = 6.0;
            double y2 = 13.0;
            double y3 = 17.0;
            double AB = 0.5 * (Math.Sqrt(x2 - x1) + Math.Sqrt(y2 - y1));
            double BC = 0.5 * (Math.Sqrt(x3 - x2) + Math.Sqrt(y3 - y2));
            double AC = 0.5 * (Math.Sqrt(x3 - x1) + Math.Sqrt(y3 - y1));

            double P = AB + BC + AC;

            Console.WriteLine("Периметр треугольника равен: " + Convert.ToInt32(P));
            Console.ReadKey();
        }
    }
}
