using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_console_app.D1Assignments
{
    public class PalindromeNumChecker
    {
        public static void Run()
        {
            Console.Write("Enter your number to check if its palindrome or not: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int copyNum = num;
            int reverse = 0;
            while (num > 0)
            {
                int lastDigit = num % 10;
                reverse = lastDigit + reverse* 10;
                num /= 10;
            }
            if (copyNum == reverse) Console.WriteLine("Palindrome");
            else Console.WriteLine("Not Palindrome");
        }
    }
}
