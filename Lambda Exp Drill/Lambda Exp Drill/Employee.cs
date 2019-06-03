using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Exp_Drill
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeID { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName + " " + EmployeeID);
        }
    }
}
