using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Task3
    {
        /*Ввести два целых числа day та month и проверить могут ли
        они представлять день та месяц. Вывести true или false*/

        static bool IsRealDate(int day, int month)
        {
            if (DateTime.DaysInMonth(2019, month) < day) return false;
            else return true;
        }
        static void Main()
        {
            Console.WriteLine("Введите номер дня: ");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер месяца: ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} дней в {1} месяце - это {2}", day, month, IsRealDate(day, month));
            Console.ReadKey();
        }
    }
}
