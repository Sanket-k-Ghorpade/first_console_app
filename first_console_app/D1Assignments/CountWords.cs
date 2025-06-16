using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_console_app.D1Assignments
{
    internal class CountWords
    {
        public static void Run()
        {
            Console.WriteLine("Enter your sentence. I will count the number of words in it!!");
            string str = Console.ReadLine();

            int wordCount = 1;

            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' || str[i] == '\t' || str[i] == '\n')
                {
                    wordCount++;
                }
            }
            Console.WriteLine($"Your Sentence has {wordCount} words");
        }
    }
}
