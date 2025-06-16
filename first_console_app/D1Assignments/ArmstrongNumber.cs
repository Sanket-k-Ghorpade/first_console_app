using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_console_app.D1Assignments
{
    public class ArmstrongNumber
    {
        public static void Run()
        {
            Console.Write("Enter your number to check if its Armstrong or not: ");
            string numStr = Console.ReadLine();
            int length = numStr.Length;

            int num = Convert.ToInt32(numStr);
            int copyNum = num;
            int armStrong = 0;

            while (num > 0) {
                int lastDigit = num % 10;
                armStrong += (int)Math.Pow(lastDigit, length);
                num /= 10;
            }
            if (armStrong == copyNum) Console.WriteLine($"{copyNum} is an Armstrong number.");
            else Console.WriteLine($"{copyNum} is not an Armstrong number.");
        }
    }
}
