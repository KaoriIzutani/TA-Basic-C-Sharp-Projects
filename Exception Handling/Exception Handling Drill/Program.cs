using System;
using System.Collections.Generic;
using Exception_Handling;

namespace Exception_Handling_Drill
{
    public class SecondClass
    {
        Exception_Handling.FirstClass obj = new Exception_Handling.FirstClass();
     static void Main(string[] args)
        {
            /*1. Create a list of integers. Ask the user for a number to divide each number in the list by. Write a loop that 
             * takes each integer in the list, divides it by the number the user entered, and displays the result to the 
             * screen.*/
            List<int> divideNumbers = new List<int> { 36, 71, 42, 108, 9 };

            for (int d = 0; d < divideNumbers.Count; d++)
            {
                Console.WriteLine(divideNumbers[d]);
                Console.ReadLine();
            }
            
        }
    }
}
