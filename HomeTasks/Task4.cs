using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Task4
    {
        /* Даны вещественные числа a, b, c, d, e. Найти площадь пятиугольника, изображенного на рис. 
        Определить функцию для расчета площади треугольника по трем его сторонам.*/
        static void Main()
        {
            int a = 16;
            int b = 24;
            int c = 9;
            int d = 10;
            int e = 7;

            double sTreugolnik1 = 0.5 * (a * b);
            double g = 0.5 * (Math.Sqrt(a) + Math.Sqrt(b));

            double sTreugolnik2 = 0.5 * (c + g);
            double f = 0.5 * (Math.Sqrt(c) + Math.Sqrt(g));

            double p = 0.5 * (e + d + f);
            double sTreugolnik3 = 0.5 * (p * (p - e) * (p - d) * (p - f));
            double sPiatiugolnika = sTreugolnik1 + sTreugolnik2 + sTreugolnik3;

            Console.WriteLine("Площадь пятиугольника равна: " + Convert.ToInt32(sPiatiugolnika));
            Console.ReadKey();
        }
    }
}
