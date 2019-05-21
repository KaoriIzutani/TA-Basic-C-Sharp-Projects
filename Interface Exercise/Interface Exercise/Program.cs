using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Exercise
{
    class Program
    {
       /*3. Use polymorphism to create an object of type IQuittable and call the Quit() method on it.
        * Hint: an object can be of an interface type if it implements that specific interface.*/

        static void Main(string[] args)
        {
            IQuittable quittable = new Employee();
            Quit(quittable);
            Console.ReadLine();

        }

        static void Quit(IQuittable quit)
        {
            quit.Quit();
        }
    }
}
