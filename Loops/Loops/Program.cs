using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12; /*Be sure you're not confusing "=", which is an 
            assignment operator, with "==", which is a comparison operator*/
            do //A "do" loop fixes the issue with the while loop.
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. That's not it.");
                        Console.WriteLine("Guess again?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break; /*You must use a break statement. Otherwise, the above statement will 
                        repeat over and over again.*/
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess again?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. That's not it.");
                        Console.WriteLine("Guess again?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed the number 12. You hit the jackpot!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess again?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!isGuessed); /*Shorthand for "isGuessed == false". Be sure to assign a var first.
            The flaw with this while loop is; what if you guessed the number correctly the
            first time? The while loop never hits, so nothing happens when you run the 
            program.*/

            Console.Read();
        }
    }
}
