using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Task2
    {
        /* Определите целочисленные переменные a и b. Считайте значения a и b из консоли
        и вычислите: a + b, a-b, a * b, a / b. Вывод полученных результатов*/

        static void Main()
        {
            Console.WriteLine("Введите а: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите b: ");
            double b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите операцию (+), (-), (*), (/)");
            char c = Console.ReadLine().ToCharArray()[0];
            double result;

            switch (c)
            {
                case '+':
                    result = a + b;
                    Console.WriteLine($"Результат операции {result}");
                    break;
                case '-':
                    result = a - b;
                    Console.WriteLine($"Результат операции {result}");
                    break;
                case '*':
                    result = a * b;
                    Console.WriteLine($"Результат операции {result}");
                    break;
                case '/':
                    result = a / b;
                    Console.WriteLine($"Результат операции {result}");
                    break;
            }
            Console.ReadKey();
        }
    }
}
