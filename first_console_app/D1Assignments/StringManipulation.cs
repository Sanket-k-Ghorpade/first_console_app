using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_console_app.D1Assignments
{
    public class StringManipulation
    {
        public static void Run(string str)
        {
            string[] strArray = str.Split(',');
            Console.WriteLine($"Developer name is: {strArray[0]}");
            Console.WriteLine($"Company name is: {strArray[1]}");
            Console.WriteLine($"Location is: {strArray[2]}");

        }
    }
}
