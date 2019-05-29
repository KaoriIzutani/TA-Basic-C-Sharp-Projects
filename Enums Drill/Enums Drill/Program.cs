
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Drill
{

    class Program
    {

        static void Main(string[] args)
        {
            /* 1. Create an enum for the days of the week.
             * 2. Prompt the user to enter the current day of the week &
              3. Assign the value to a variable of that enum data type you just created &
              4. Wrap the above statement in a try/catch block and have it print "Please enter an actual day 
              of the week." to the console if an error occurs.*/


            try
            {
                Console.WriteLine("Enter today's day of the week: ");
                string enteredDay = Console.ReadLine();
                Weekday chosenDay = (Weekday)Enum.Parse(typeof(Weekday), enteredDay);


            switch (chosenDay)
                {
                    case Weekday.Monday:
                        Console.WriteLine("Hate Mondays.");
                        break;
                    case Weekday.Tuesday:
                        Console.WriteLine("Tuesdays are OK.");
                        break;
                    case Weekday.Wednesday:
                        Console.WriteLine("It's Wednesday, midway through the week.");
                        break;
                    case Weekday.Thursday:
                        Console.WriteLine("It's Thursday, almost Friday..");
                        break;
                    case Weekday.Friday:
                        Console.WriteLine("It's Friday. Are you off tomorrow?");
                        break;
                    case Weekday.Saturday:
                        Console.WriteLine("Finally it's Saturday, the weekend!");
                        break;
                    case Weekday.Sunday:
                        Console.WriteLine("Nothing to do on Sundays.");
                        break;
                    default:
                        break;
                }
                Console.ReadLine();
            }

            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }

                   

                }
            }
                   public enum Weekday
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        
            }




     
    
    


