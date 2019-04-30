using System;
using System.Collections.Generic;


namespace Exception_Handling_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
         
                /*1. Create a list of integers. Ask the user for a number to divide each number in the list by. Write a loop that 
                 * takes each integer in the list, divides it by the number the user entered, and displays the result to the 
                 * screen.*/
                List<int> divideNumbers = new List<int> { 36, 71, 42, 108, 7 };

                foreach (int number in divideNumbers)
                {


                try

                {
                    //Console.WriteLine("Pick a number to divide: ");
                    //int firstNumber = Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine("Now pick a second number: ");
                    //int secondNumber = Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine("Dividing..");
                    //int thirdNumber = (firstNumber / secondNumber);
                    //Console.WriteLine(firstNumber + " divided by " + secondNumber + " equals " + thirdNumber);
                    Console.WriteLine(divideNumbers[number]);
                    Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine();
                }
                finally
                {
                    Console.ReadLine();
                }
                }

            }
        }
    }

    

