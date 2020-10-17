using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Task7
    {
        /*Read the text as a string value and calculate the counts
        of characters 'a', 'o', 'i', 'e' in this text.*/
        static void Main()
        {
            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();

            Console.WriteLine("Введите символ: ");
            char x = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(Count(text, x));
            Console.ReadKey();
        }
        public static int Count(string text, char x)
        {
            int res = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == x)
                    res++;
            }
            return res;
        }
    }
}
