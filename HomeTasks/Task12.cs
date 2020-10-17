using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Task12
    {
        /*Вывод вопроса «Как дела?». Определите строковую переменную ответа. Прочитайте значение
        ответа и выведите: «Вы есть (ответ)»*/
        static void Main(string[] args)
        {
            Console.WriteLine("How are you?");
            string otvet = Console.ReadLine();
            Console.WriteLine($"You are {otvet}");

            Console.ReadKey();
        }
    }
}
