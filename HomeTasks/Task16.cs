using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Task16
    {
        /*Ввести ціле число h , які представляють час доби (година ). В залежності від
        часу доби вивести привітання («Доброго ранку!», «Доброго дня!»,
        «Доброго вечора!», «Доброї ночі!»)*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите время: ");
            int time = Convert.ToInt32(Console.ReadLine());

            if ((time >= 6) && (time <= 11))
                Console.WriteLine("Доброе утро!");
            if ((time >= 12) && (time <= 17))
                Console.WriteLine("Добрый день!");
            if ((time >= 18) && (time <= 21))
                Console.WriteLine("Добрый вечер!");
            if (time >= 22)
                Console.WriteLine("Доброй ночи!");
            if ((time >= 1) && (time <= 5))
                Console.WriteLine("Доброй ночи!");
            Console.ReadKey();
        }
    }
}
