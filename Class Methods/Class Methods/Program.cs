using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods
{
 
    class Program
    /*2. In the Main() method, instantiate that class &

      3. Have the user enter a number. Call the method on that number. Display the output to the screen. It should 
        be the entered number, divided by two.*/

    {
        public static void Main(string[] args)
        {
            MathDivide divide = new MathDivide();
            Console.WriteLine("Enter a number you want to divide: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(userInput + " divided by 2 equals: ");
            divide.Divide(userInput);

            MathDivide addition = new MathDivide();
            Console.WriteLine("Enter an integer: ");
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(addition.Addition(userInput2, out int l));

            Console.WriteLine("Enter another integer: ");
            int userInput3 = Convert.ToInt32(Console.ReadLine());
            addition.Divide(userInput3);
            Console.ReadLine();
        }
        
    }
}
