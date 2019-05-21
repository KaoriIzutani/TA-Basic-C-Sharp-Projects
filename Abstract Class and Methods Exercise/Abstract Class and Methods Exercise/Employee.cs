using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_and_Methods_Exercise
{
    /*3. Create another class called Employee and have it inherit from the Person class &
      4. Implement the SayName() method inside of the Employee class.*/

    class Employee : Person
    {
        public void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
