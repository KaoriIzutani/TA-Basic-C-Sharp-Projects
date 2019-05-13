using System;
using System.Collections.Generic;



    class Program
    {
        static void Main(string[] args)
        {
            List<string> picnicItems = new List<string>() { "sandwich", "picnic basket", "frisbee", "potato salad" };

            foreach (string picnicItem in picnicItems)
            {
                Console.WriteLine(picnicItems);
            }

            Console.ReadLine();
        }
    }


