using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_console_app.D1Assignments
{
    public class ReverseNumber
    {
        public static void Run()
        {
            Console.Write("Enter a number to be reversed: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int reversed = 0;
            while (num > 0)
            {
                int lastDigit = num % 10;
                reversed = lastDigit + reversed * 10;
                num = num / 10;
            }
            Console.WriteLine("Reverse is "+reversed);
        }
    }
}
