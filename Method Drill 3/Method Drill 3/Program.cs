using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Drill_3
{
    class Program
    {
        /*2. In the Main() method of the console app, instantiate the class &
         * 
         *3. Ask the user to input two numbers, one at a time. Let them know 
         * they need not enter anything for the second number &
         * 
         *4. Call the method in the class, passing in the one or two numbers entered &
         * 
         *5. Try various combinations of numbers on the code, including having no second number.*/

        public static void Main(string[] args)
        {
            MathSubtract subtract = new MathSubtract();
            Console.WriteLine("Enter a number you want to subtract: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number (optional): ");
            string userInput = Console.ReadLine();
            
            if (userInput != "")
            {
                int i = Convert.ToInt32(userInput);
                int result = MathSubtract.Subtract(h, i);
                Console.WriteLine("{0} - 10 - {1} = {2}", h, i, result);
            }

            else
            {
                int result = MathSubtract.Subtract(h);
                Console.WriteLine("{0} - 10 = {1}", h, result);
            }

         Console.ReadLine();
        }
        

        
    }
}
