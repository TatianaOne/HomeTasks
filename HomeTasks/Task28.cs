using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Task28
    {
        /*Ввести назву напитку (кава, чай, сік, вода). Вивести назву напитку і його 
        ціну*/
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите напиток: ");
            string drink = Console.ReadLine();

            if (drink == "Coffee")
            {
                Console.WriteLine("Coffee costs 2.50 evro");
            }
            else if (drink == "Tea")
            {
                Console.WriteLine("Tea costs 2.00 evro");
            }
            else if (drink == "Juice")
            {
                Console.WriteLine("Juice costs 3.00 evro");
            }
            else
            {
                Console.WriteLine("Water costs 1.50 evro");
            }
            Console.ReadKey();
        }
    }
}
