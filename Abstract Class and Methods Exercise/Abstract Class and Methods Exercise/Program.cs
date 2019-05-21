using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_and_Methods_Exercise
{
   /* 5. Inside the Main() method, instantiate an Employee object with firstName "Sample" and lastName "Student".
    * Call the SayName() method on the object.*/

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
            Console.ReadLine();
        }
    }
}
