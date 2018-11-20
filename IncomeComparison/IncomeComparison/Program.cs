using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)


        {
            string StartComparison = "Anonymous Income Comparison Program";
            Console.WriteLine(StartComparison);
            Console.WriteLine("Person 1");
            Console.WriteLine("Enter Person 1's Hourly Rate in whole numbers: ", Console.ReadLine());
            int HourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("$"+ HourlyRate + " is the hourly rate.");

            Console.WriteLine("Enter hours worked per week: ",Console.ReadLine());
            int HoursWorked = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 1 worked "+ HoursWorked + " hours per week.");
            Console.ReadLine();


            Console.WriteLine("Person 2");
            Console.WriteLine("Enter Person 2's Hourly Rate in whole numbers: ", Console.ReadLine());
            int HourlyRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("$" + HourlyRate2 + " is the hourly rate.");

            Console.WriteLine("Enter hours worked per week: ", Console.ReadLine());
            int HoursWorked2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2 worked " + HoursWorked2 + " hours per week.");
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 1");
            int AnnualSalary = HoursWorked * 52 * HourlyRate;
            Console.WriteLine("Person 1's annual salary is " + "$" + AnnualSalary + " per year.");
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 2");
            int AnnualSalary2 = HoursWorked2 * 52 * HourlyRate2;
            Console.WriteLine("Person 2's annual salary is " + "$" + AnnualSalary2 + " per year.");
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money annually than Person 2?");
            bool makesMore = AnnualSalary > AnnualSalary2;
            Console.WriteLine(makesMore);
            Console.ReadLine();




        }
    }
}
