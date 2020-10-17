using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Task29
    {
        /*Введіть послідовність додатніх цілих чисел (до першого від’ємного). 
Обчисліть середнє арифметичне значення введених чисел*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[N];
            Random rand = new Random();
            int sum = 0;

            Console.WriteLine();

            for (int i = 0; i < N; i++)
            {
                arr[i] = rand.Next(0, 10);
                sum += arr[i];
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое: " + (double)sum / N);

            Console.ReadKey();
        }
    }
}
