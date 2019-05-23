using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading_Drill
{
/* Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.*/

    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }



        public static bool operator ==(Employee e1, Employee e2)
        {
            if (e1.Id == e2.Id)
            {
                return true;
             }

            else
            {
                return false;

             }

        }

        public static bool operator!= (Employee e1, Employee e2)
        {
            if (e1.Id != e2.Id)
            {
                return true;
            }

            else
            {
                return false;

            }
        }
        }
    }

