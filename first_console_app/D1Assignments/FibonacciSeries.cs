using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_console_app.D1Assignments
{
    public class FibonacciSeries
    {
        public static void Run()
        {
            Console.Write("Enter the number. I will provide you fibonacci series for that number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int t1 = 1, t2 = 1, nextTerm=0;
            Console.Write(t1 + " " + t2);
            for(int i = 2; i < num; i++)
            {
                nextTerm = t1 + t2;
                Console.Write(" "+nextTerm);
                t1 = t2;
                t2 = nextTerm;
            }

        }
    }
}
