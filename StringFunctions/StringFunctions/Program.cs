using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Kaori";
            string quote = "The man said, \"Hello\", Kaori. \n This goes on a new line. \n \t Hello on a tab." ; 
            /*Escape characters are indicated by the back slash. "\n" creates a new line. \n \t creates a tab.*/

            Console.WriteLine(quote);
            Console.ReadLine();
        }
    }
}
