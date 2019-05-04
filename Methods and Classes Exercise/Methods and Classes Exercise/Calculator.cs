using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Classes_Exercise
{
/* 1. Create a class. In that class, create three methods, each of which will take one integer parameter in 
 * and return an integer. The methods should do some math operation on the received parameter. Put this class 
 * in a separate .cs file in the application.*/

    public class Calculator
    {
        public int x { get; set; }
        public int y { get; set; }

        public static int Add(int x) /*Method #1*/
        {
            int y = 12;
            y = y + x;
            return y;
        }
        
        public static int Divide (int x) /*Method #2*/
        {
            int y = 12;
            y = x / y;
            return y;
        }

        public static int Multiply (int x) /*Method #3*/
        {
            int y = 12;
            y = y * x;
            return y;
        }
            
        

    }
}
