using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Task9
    {
        /*Enter 10 integer numbers. Calculate the sum of first 5 elements if they are
        positive or product of last 5 element in the other case.*/
        static void Main()
        {
            try
            {
                Console.WriteLine("Введите размерность массива: ");
                int n = int.Parse(Console.ReadLine());
                int[] myArray = new int[n];

                Console.WriteLine("Введите элементы массива: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write("myArray[{0}]=", i);
                    myArray[i] = int.Parse(Console.ReadLine());
                }
                int sum = 0;
                int pro = 0;
                for (int i = 0; i < myArray.Length; i++)
                {
                    if (myArray[i] > 0 && i <= 4)
                    {
                        sum += myArray[i];
                        i++;
                    }
                    else
                    {
                        pro *= myArray[i];
                    }
                }
                Console.WriteLine("Сумма первых пяти элементов равна: " + sum);
                Console.WriteLine("Произведение вторых пяти элементов равна: " + pro);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }
}
