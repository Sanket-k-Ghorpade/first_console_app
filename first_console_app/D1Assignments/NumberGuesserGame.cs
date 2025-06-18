using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_console_app.D1Assignments
{
    public class NumberGuesserGame
    {
        public static void Run()
        {
            Random rnd = new Random();
            bool replay = true;
            int num = rnd.Next(1, 100);
            int attempts = 1;

            Console.WriteLine("------Number Guessing Game-------");
            Console.WriteLine("\nI have chosen a number between 1 to 100. Can you guess it correctly??");
            Console.Write("\nYour guess is: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            while (replay)
            {
                while (guess != num)
                {
                    if (guess < num)
                    {
                        Console.Write("\nSorry,too low guess again: ");
                        guess = Convert.ToInt32(Console.ReadLine());
                        attempts++;
                    }
                    else
                    {
                        Console.Write("\nSorry,too high guess again: ");
                        guess = Convert.ToInt32(Console.ReadLine());
                        attempts++;
                    }
                }
                Console.WriteLine($"\n********** Bingo!! You Guessed it. Correct number was {num} **********");
                Console.WriteLine($"\nNo of attempts: {attempts}");
                Console.WriteLine("\nDo you want to play it again?? (Yes/No)");
                if (Console.ReadLine() == "Yes")
                {
                    num = rnd.Next(1, 100);
                    Console.WriteLine("\nI have chosen a number between 1 to 100. Can you guess it correctly??");
                    Console.Write("\nYour guess is: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    attempts = 1;
                } else break;
            }
            Console.WriteLine("\n------ Thank You For Playing ------");
        }
    }
}
