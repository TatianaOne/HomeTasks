using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Task14
    {
        /*Найти значение выражения, где n! означает факториал числа n(n!=1*2*...*n).
        Определить функцию для расчета факториала натурального числа.*/
        static void Main()
        {
            double F = (2 * Fact(5) + 3 * Fact(8)) / (Fact(6) + Fact(4));
            Console.WriteLine("Выражение равно: " + F);
            Console.ReadKey();

            int Fact(int n)
            {
                int i, f = 1;
                for (i = 1; i <= n; i++)
                    f = f * i;
                return f;
            }
        }
    }
}
