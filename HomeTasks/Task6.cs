﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Task6
    {
        /*Перевірити чи введене натуральне число містить лише непарні цифри*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Число содержит парные цифры.");
            }
            else
                Console.WriteLine("Число содержит непарные цифры.");
            Console.ReadKey();
        }
    }
}
