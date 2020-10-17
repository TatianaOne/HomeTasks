using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Task15
    {
        /*Прочитайте 3 переменные типа char.
        Напишите сообщение: «Вы вводите (первый символ), (второй символ), (3 символа)»*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первый символ: ");
            char x = Console.ReadLine().ToCharArray()[0];

            Console.WriteLine("Введите второй символ: ");
            char y = Console.ReadLine().ToCharArray()[0];

            Console.WriteLine("Введите третий символ: ");
            char z = Console.ReadLine().ToCharArray()[0];

            Console.WriteLine($"Вы ввели {x}, {y}, {z}");
            Console.ReadKey();
        }
    }
}
