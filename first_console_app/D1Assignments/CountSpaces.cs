using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_console_app.D1Assignments
{
    public class CountSpaces
    {
        public static void Run()
        {
            Console.WriteLine("Enter the sentence: ");
            string str = Console.ReadLine();
            int spaceCount = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ') { spaceCount++; }
            }
            Console.WriteLine($"Total Space: {spaceCount}");
        }
    }
}
