using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee() { FirstName = "Kaori", LastName = "Izutani", Id = 1 };
            Employee e2 = new Employee() { FirstName = "Kaori", LastName = "Izutani", Id = 3 };
            Employee e3 = new Employee() { FirstName = "Kaori", LastName = "Izutani", Id = 3 };

            Console.WriteLine(e1 == e3);
            Console.WriteLine(e2 == e3);
            Console.WriteLine(e1 != e2);
            Console.ReadLine();
        }
    }
}
