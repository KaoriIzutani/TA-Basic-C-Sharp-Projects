using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Drill_3
{
    /*1. Create a class. In that class, create a method that takes two integers as parameters. Make one 
     * of them optional. Have the method do a math operation and return a integer result.*/

    class MathSubtract
    {
        public static int Subtract(int h, int i = 0)
        {
            int result = h - 10 - i;
            return result;

        }
    }
}
