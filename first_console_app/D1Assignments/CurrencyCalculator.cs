using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_console_app.D1Assignments
{
    public class CurrencyCalculator
    {
        public static void Run()
        {
            Console.Write("Enter Withdrwal amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            if (amount < 0)
            {
                Console.WriteLine("Amount can't be negative !");
            }
            else if (amount > 50000)
            {
                Console.WriteLine("Amount exceeds withdrwal limit of 50000 !");
            }
            else if (amount % 100 != 0)
            {
                Console.WriteLine("Amount should be in multiples of 100");
            }
            else
            {
                while (amount > 0)
                {
                    if (amount >= 2000)
                    {
                        int T2000 = amount / 2000;
                        amount -= T2000 * 2000;
                        Console.WriteLine($"Two thousand: {T2000}");
                    }
                    else if (amount >= 500)
                    {
                        int T500 = amount / 500;
                        amount -= T500 * 500;
                        Console.WriteLine($"Five hundread: {T500}");
                    }
                    else if (amount >= 200)
                    {
                        int T200 = amount / 200;
                        amount -= T200 * 200;
                        Console.WriteLine($"Two hundread: {T200}");
                    }
                    else
                    {
                        int T100 = amount / 100;
                        amount -= T100 * 100;
                        Console.WriteLine($"Hundread: {T100}");
                    }
                }
            }
        }
    }
}
