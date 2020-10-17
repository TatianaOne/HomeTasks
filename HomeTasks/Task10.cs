using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Task10
    {
        /*Дано массив а из положительных элементов и массив в из отрицательных элементов.
        Массивы задано диагонально. Создать массив с, который будет состоять из чередующихся
        элементов массива а и массива в. Массивы а и в имеют разную длину.*/
        static void Main()
        {
            int[] a = { 1, 2, 3, 4, 5, 6 };
            int[] b = { -8, -7, -6, -5, -4, -3, -2, -1 };
            int[] c = new int[a.Length + b.Length];

            for (int i = 0, j = 0; i < c.Length; j++)
            {
                if (j < a.Length)
                    c[i++] = a[j];
                if (j < b.Length)
                    c[i++] = b[j];
            }
            foreach (int item in c)
                Console.WriteLine($"{item} ");

            Console.ReadLine();
        }
    }
}
