using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Classes_Exercise
{
    class Program
    {
    /*2. In the Main() program, ask the user what number they want to do the math operations on.*/

        static void Main(string[] args)
        {
            Console.WriteLine("What number would you like to do math on?");
            int x = Convert.ToInt32 (Console.ReadLine());
            int finalAnswer;
            Console.WriteLine("You entered " + x);


            /*3. Call each method in turn, passing the user input to the method. Display the returned integer 
             * to the screen.*/

            finalAnswer = Calculator.Add(x);
            Console.WriteLine(x + " plus 12 equals " + finalAnswer);
           

            finalAnswer = Calculator.Divide(x);
            Console.WriteLine(x + " divided by 12 equals " + finalAnswer);
            

            finalAnswer = Calculator.Multiply(x);
            Console.WriteLine(x + " times 12 equals " + finalAnswer);
            Console.ReadLine();
        }
    }
}
