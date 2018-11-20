using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void NotMain(string[] args)
        {
            Console.WriteLine(true && false);
            Console.WriteLine(true && true);
            Console.WriteLine(true && true && true && false);//This evaluates to false, as ALL statements must be true
            Console.ReadLine();

            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);
            //Console.ReadLine();

            //Console.WriteLine(true == true); /*Make sure you're using two = signs, or it won't compare the statements
            //properly*/
            //Console.WriteLine(true == false);
            //Console.ReadLine();


            Console.WriteLine(true ^ true); /*The carat (X OR) operator only evaluates to "true" if one is "true", BUT 
            not both. The answers evaluate to "False, True, False" in this example.*/
            Console.WriteLine(true ^ false);
            Console.WriteLine(false ^ false);
            Console.ReadLine();

        }
    }
}
