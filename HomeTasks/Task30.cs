using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Task30
    {
        /*Перевірити чи введений рік є високосним*/
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите год:");
                int year = Convert.ToInt32(Console.ReadLine());
                if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                {
                    Console.WriteLine("Leap Year");
                }
                else
                {
                    Console.WriteLine("Not Leap Year");
                }
                Console.ReadLine();
            }
        }
    }
}
