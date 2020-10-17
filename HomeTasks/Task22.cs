using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Task22
    {
        /*прочитать 3 числа с плавающей точкой и проверить: все ли они
        принадлежат диапазону [-5,5]*/
        static void Main()
        {
            Console.WriteLine("Введите число: ");
            double value = Convert.ToDouble(Console.ReadLine());

            double upperSide = 0.0;
            double lowSide = -5.5;

            if (value >= lowSide && value <= upperSide)
            {
                Console.WriteLine("Число входит в диапазон от -5.5 до 0!");
            }
            else
            {
                Console.WriteLine("Число не входит в диапазон от -5.5 до 0!");
            }
            Console.ReadKey();
        }
    }
}
