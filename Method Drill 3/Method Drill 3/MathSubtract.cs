using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Drill_3
{
    /*Step 115:
     * 1. Create a class. In that class, create a method that takes two integers as parameters. Make one 
     * of them optional. Have the method do a math operation and return a integer result.*/

    class MathSubtract
    {
        public int Subtract(int h, int i = 1977)
    {
            int result = h - i ;
            i = h - i;
            return i;

    }

}

       
}
