using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Task26
    {
        /*Ввести рядок символів. Видрукувати кожен другий символ*/
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Ведите строку: ");
                string text = Console.ReadLine();

                int i;
                for (i = 0; i < text.Length; i += 2)
                {
                    Console.Write(i);
                }
                Console.ReadKey();
                return;
            }
        }
    }
}
