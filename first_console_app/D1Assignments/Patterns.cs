using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_console_app.D1Assignments
{
    public class Patterns
    {
        public static void Run()
        {
            Console.Write("Enter a number for pattern: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 1; i <= num; i++) 
            { 
                for (int j = 1; j<= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine() ;
            }

            Console.WriteLine();

        }
    }
}
