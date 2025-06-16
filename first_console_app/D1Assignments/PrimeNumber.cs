using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_console_app.D1Assignments
{
    public class PrimeNumber
    {
        public static void Run()
        {
            Console.WriteLine("Enter your number to check if its prime or not");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num <= 1) { Console.WriteLine($"{num} is not a prime number"); }

            else
            {
                bool isPrime = true;

                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine($"{num} is a prime number");
                }
                else
                {
                    Console.WriteLine($"{num} is not a prime number");
                }
            }
        }
    }
}
