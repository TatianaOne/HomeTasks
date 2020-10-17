using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Task17
    {
        /* Получить все шестизначные счастливые номера. Счастливыми называют такое
        шестизначное число, в котором сумма его первых трех цифр равна сумме
        его последних трех цифр.(Определить функцию для расчета суммы цифр
        трехзначного числа.)*/
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, num5, num6 = 0;
            int summa = 0;
            for (int i = 000000; i <= 999999; i++)
            {
                num1 = i % 10;
                num2 = (i / 10) % 10;
                num3 = (i / 100) % 10;
                num4 = (i / 1000) % 10;
                num5 = (i / 10000) % 10;
                num6 = (i / 100000) % 10;

                if (num1 + num2 + num3 == num4 + num5 + num6) summa++;
            }
            Console.WriteLine("Счастливых билетов" + " " + (summa));
            Console.ReadKey(true);
        }
    }
}
