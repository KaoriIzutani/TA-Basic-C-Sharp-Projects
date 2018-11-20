using System;

namespace CarInsurance
{


    static class Program
    {
        static void Main()
        {
            string CarInsurance = "Car Insurance Pre-Approval Form";
            Console.WriteLine(CarInsurance);
            Console.WriteLine("What is your age?");
            int CurrentAge = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Have you ever had a DUI? Please enter true or false.");
            bool DUIArrested = Convert.ToBoolean(Console.ReadLine());
            
            Console.WriteLine("How many speeding tickets do you have?");
            int HaveTicket = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");
            Console.WriteLine(CurrentAge > 15 && DUIArrested != true && HaveTicket < 3);
            Console.ReadLine();

            
        }
    }
}