using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main()
        {
            string message = @"The Tech Academy
 Student Daily Report";
            
            Console.WriteLine(message);
            Console.Write("What course are you on? ");
            Console.ReadLine();
            Console.Write("What page number? ");
            Console.ReadLine();
            Console.Write("Do you need help with anything? Please answer \"true\" or \"false.\" ");
            Console.ReadLine();
            Console.Write("Were there any positive experiences you'd like to share? Please give specifics: ");
            Console.ReadLine();
            Console.Write("Is there any other feedback you'd like to provide? Please be specific: ");
            Console.ReadLine();
            Console.Write("How many hours did you study today? ");
            Console.ReadLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
