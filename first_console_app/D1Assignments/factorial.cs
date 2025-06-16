using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_console_app.D1Assignments
{
    public class factorial
    {
       public static void Run()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for(int i = 2; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine($"Factorial of {num} is {fact}.");
        }
    }
}
