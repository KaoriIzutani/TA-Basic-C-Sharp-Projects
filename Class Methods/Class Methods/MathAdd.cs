using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods
{
    
      /*6. Declare a class to be static.*/

    static class MathAdd
    {
        


        public static int Addition(int k, out int l)
        {
            l = k + 2;
            return k + l;


        }
    }
}
