using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods
{
    /*1. Create a class. In that class, create a void method that outputs an integer. Have the method 
     * divide the data passed to it by 2.*/ 
     
    

     class MathDivide
    {
        public void Divide(int j)
        {
            int mathDiv = j / 2;
            Console.WriteLine(mathDiv);
           
        }

        /*4. Create a method with output parameters &
         * 
          5. Overload a method.*/
          

    public int Addition(int k, out int l)
        {
            l = k + 2;
            return k + l;

           
            }

     public int Addition(int m, int n, int o)
        {
            return m + n + o;
        }
        

    }
}
