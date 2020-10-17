using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    class Task19
    {
        /*Визначити перелічення TestCaseStatus (Pass, Fail, Blocked, WP, Unexecuted).
        Змінній test1Status присвоїти значення Pass і вивести значення змінної  на консоль.*/
        enum TestCaseStatus
        {
            Pass,
            Fail,
            Blocked,
            WP,
            Unexecuted,
        }
        class Program
        {
            static void Main(string[] args)
            {
                TestCaseStatus test1Status;
                test1Status = TestCaseStatus.Pass;
                Console.WriteLine(test1Status);
                Console.ReadKey();
            }
        }
    }
}
