using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Task20
    {
        /* Даны два предложения, в которых имеются буквы ш. Найти, в каком из них эта
        буква имеет больший порядковый номер (при счете от начала предложения).
        Если в предложении имеется несколько букв ш, тодолжна быть учтена последняя
        из них. (Определить функцию для нахождения порядкового номера буквы последнего
        вхождения в предложение некоторой буквы.)*/
        static void Main()
        {
            int position1, position2 = 0;
            string sentence1 = "Шла Маша по шоссе и сосала соску";
            string sentence2 = "Дедушка нашёл бабушкину брошку";

            position1 = sentence1.LastIndexOf("ш");
            position2 = sentence2.LastIndexOf("ш");
            Console.WriteLine(" 'ш' at position {0}", position1);
            Console.WriteLine(" 'ш' at position {0}", position2);
            Console.ReadKey();
        }
    }
}
