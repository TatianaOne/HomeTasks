using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Task13
    {
        /*Ввести дійсне число  number і отримати 2 перші цифри після коми
        цього числа. Вивести суму цих цифр. Напр.: 3.456->4+5=9*/
        static void Main()
        {
            double number;
            int firstPart, secondPart;
            if (Double.TryParse(Console.ReadLine(), out number))
            {
                firstPart = (Int32)((number - (Int32)number) * 10);
                secondPart = (Int32)((number * 10 - (Int32)(number * 10)) * 10);
                Console.WriteLine("Cумма чисел после запятой у {0} : {1}+{2}={3}", number, firstPart, secondPart, firstPart + secondPart);
            }
            else
            {
                Console.WriteLine("Число введено неверно!!!");
            }
            Console.ReadKey();
        }
    }
}
