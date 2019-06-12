using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTime_Exercise
{
    class Program
    {

        /*1. Prints the current date and time to the console.

          2. Asks the user for a number.

          3. Prints to the console the exact time it will be in X hours, X being the number the user entered
          in step 2.*/

        static void Main(string[] args)
        {
           
            Console.WriteLine("Right now, it is currently " + DateTime.Now);

            Console.WriteLine("Enter a number: ");
            double enteredNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine( "You've added " + enteredNumber + " hours. Now it is " 
                + DateTime.Now.AddHours(enteredNumber));
           
            Console.ReadLine();
        }
    }
}
