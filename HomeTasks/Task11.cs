using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Task11
    {
        static void Main(string[] args)
        {
            const int n = 3;
            const int m = 4;
            int[] a = new int[n] { 1, 2, 3 };
            Console.WriteLine("Исходный массив А");
            for (int i = 0; i < n; ++i)
                Console.WriteLine(a[i]);

            int[] b = new int[m] { 4, 5, 6, 7 };
            Console.WriteLine("Исходный массив B");
            for (int i = 0; i < m; ++i)
                Console.WriteLine(b[i]);

            int[] myList = new int[n + m];
            for (int i = 0; i < n; ++i)
                myList[i] = a[i];
            for (int i = 0; i < m; ++i)
                myList[i + n] = b[i];
            Console.WriteLine("Полученный массив С");
            for (int i = 0; i < n + m; ++i)
                Console.WriteLine(myList[i]);

            Console.ReadKey();
        }
    }
}
