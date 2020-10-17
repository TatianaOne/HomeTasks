using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Task8
    {
        /*Ask user to enter the number of month. Read the value and write
        the amount of days in this month*/
        static void Main()
        {
            Console.WriteLine("Введите номер месяца: ");
            int month = Convert.ToInt32(Console.ReadLine());

            int result = System.DateTime.DaysInMonth(2019, month);

            Console.WriteLine($"В этом месяце {result} дней");
            Console.ReadKey();
        }
    }
}
