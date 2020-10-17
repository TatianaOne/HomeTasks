using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Task24
    {
        /*объявить структуру Dog с полями Name, Mark, Age. Объявите переменную
        myDog типа Dog и прочитайте для нее значения. Выведите myDos в консоль.
        (Объявить метод ToString в структуре)*/
        struct Dog
        {
            public string name;
            public string mark;
            public int age;

            public void ForString()
            {
                Console.WriteLine($"Dog name is {name}, mark is {mark} and his age is {age}.");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Dog myDog;
                myDog.name = "Sharik";
                myDog.mark = "Buldog";
                myDog.age = 4;
                myDog.ForString();
                Console.ReadKey();
            }

        }
    }
}
