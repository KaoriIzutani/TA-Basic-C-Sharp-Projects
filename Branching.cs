﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void NotMain(string[] args)
        {
            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 8 ? "You have an awesome favorite number." : "You have a lame favorite number.";
            Console.WriteLine(result);
            //int roomTemperature = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");

            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("It is colder than room temperature");
            //}
            //else
            //{
            //    Console.WriteLine("Something went wrong..");
            //}

        //    int currentTemperature = 80;
        //    int roomTemperature = 70;

            //This code is shorthand for the if (currentTemperature == roomTemperature)
            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature."); 
            //This is called a "ternary operator". }. Very efficient way of writing out comparison statement
            
            //string comparisonResult = currentTemperature == roomTemperature ? "It is room temp."/*Assigning this if 
            //  var comparisonResult is true*/ : "It is not room temp.";/*Assigning this if var comparisonResult is false*/
            //Console.WriteLine(comparisonResult);
        

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");    
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("Room temperature is warmer than current temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature.");
            //}
            Console.ReadLine();
        }
    }
}