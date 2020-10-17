using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Task25
    {
        /*Определить имя строковой переменной и целочисленное значение age.
        Выведите вопрос «Как вас зовут?», Прочитайте имя значения и выведите
        следующий вопрос: «Сколько вам лет, (имя)?». Читайте возраст и пишите
        всю информацию.*/
        static void Main()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine($"How old are you, {name}?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your name is {name} and your age is {age}. Congratulations, you have a beautiful name and a great age.");
            Console.ReadKey();
        }
    }
}
