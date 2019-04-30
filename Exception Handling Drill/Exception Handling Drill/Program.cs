using System;
using System.Collections.Generic;


namespace Exception_Handling_Drill
{
    class Program
    {
        static void Main(string[] args)
        {

            /*  1. Create a list of integers. Ask the user for a number to divide each number in the list by. Write a loop 
             *  that takes each integer in the list, divides it by the number the user entered, and displays the result to 
             *  the screen.
             &  2.  Run that code, entering in non-zero numbers as the user. Look at the displayed results.

             &  3. Run that code, entering in zero as the number to divide by. Note any error messages you get. (Got a 
             System.DivideByZero Exception error)

             &  4. Run that code, entering in a string as the number to divide by. Note any error messages you get.  (Got a 
             System.Format Exception error)*/

            List<int> divideNumbers = new List<int> { 36, 71, 42, 108, 7 };

            foreach (int number in divideNumbers)
            {
                Console.WriteLine("Pick a number to divide: ");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing..");
                int secondNumber = number / firstNumber;
                Console.WriteLine(firstNumber + " divided by " + number + " equals " + secondNumber);
                Console.ReadLine();

            }

            /*5. Now put the loop in a try/catch block. Below and outside of the try/catch block, make the program
             * display a message to let you know the program has emerged from the try/catch block and continued on 
             * with program execution. In the catch block, display the error message to the screen. Then try various 
             * combinations of user input: valid numbers, zero and a string. Ensure the proper error messages 
             * display on the screen, and that the code after the try/catch block
             * gets executed.*/


            try
            {
                foreach (int number in divideNumbers)
                {
                    Console.WriteLine("Pick a number to divide: ");
                    int firstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Dividing..");
                    int secondNumber = number / firstNumber;
                    Console.WriteLine(firstNumber + " divided by " + number + " equals " + secondNumber);
                    Console.ReadLine();
                    
                }
            }
            catch (DivideByZeroException ex1)
            {
                Console.WriteLine("You cannot divide by zero.");

            }

            catch (FormatException ex1)
            {
                Console.WriteLine("This program will not accept text. Please enter a whole number.");

            }

            finally
            {
                Console.WriteLine("Thank you. Press enter to end the program.");


                Console.ReadLine();
            }


        }
    }
}
    

    

