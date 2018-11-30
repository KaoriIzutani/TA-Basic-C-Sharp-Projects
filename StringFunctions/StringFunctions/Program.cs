using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void NotMain(string[] args)
        {
            string name = "Camus";
            name = "Joe";


            //string quote = "The man said, \\Hello, Kaori\". \n This goes on a new line. \n \t Hello on a tab." ;
            //string fileName = @"C:\Users\Kaori";
            ///*Escape characters are indicated by the back slash. "\n" creates a new line. "\n \t" creates a tab.
            // "\\ results in one backslash showing in your string.*/

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length; /*Length is a property of this string, 
            //which we assigned the var "name"*/

            name = name.ToUpper(); /*This converted what was assigned to the var "name" into 
            upper (ToUpper property) or lower case (ToLower).*/

            StringBuilder sb = new StringBuilder(); /*StringBuilder is a dynamic object. More on 
            what a dynamic object is later on*/
            sb.Append("My name is Kaori.");

            Console.WriteLine(name);
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
