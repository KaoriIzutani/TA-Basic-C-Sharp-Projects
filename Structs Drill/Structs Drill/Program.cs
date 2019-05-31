using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_Drill
{
    class Program
    {
        /*2. In the Main() method, create an object of data type Number and assign an amount to it.*/

        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 41.41m;
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
