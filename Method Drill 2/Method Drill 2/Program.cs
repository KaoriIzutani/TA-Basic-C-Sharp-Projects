using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Drill_2
{
    class Program
    {
        /*2.  In the Main() method of the console app, instantiate the class and call the one method, 
         * passing in an integer, such as 12. Then display the result to the screen.*/

        static void Main(string[] args)
        {
            MathMultiply multiply = new MathMultiply();
            Console.WriteLine("Enter in a number you want to multiply by 4: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(h + " multiplied by 4 equals " + multiply.Multiply(h));
            
            Console.ReadLine();

        }
        
       
    }
}
