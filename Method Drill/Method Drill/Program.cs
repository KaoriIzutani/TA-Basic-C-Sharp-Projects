using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Drill
{
    class Program
    {
        /*2. In the Main() method of the console app, instantiate the class.*/

        public static void Main(string[] args)
        {
            MathOperation operation = new MathOperation();
            Console.WriteLine("Enter a number you want to subtract 2 to: ");
            int d = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Enter a number you want to be displayed: ");
            int e = Convert.ToInt32(Console.ReadLine());
            

            /*3. Call the method in the class, passing in two numbers.*/
            Console.WriteLine("The answer is: ");
            operation.Subtract(d,e);


            /*4. Call the method in the class, specifying the parameters by name.*/
            Console.WriteLine("The answer is: ");
            operation.Subtract(b: d, c: e);
            Console.ReadLine();


        }
    }
   
}
