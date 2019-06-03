using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Exp_Drill
{
    class Program
    {
        /*1. In the Main() method, create a list of at least 10 employees. Each employee should have a 
         * first and last name, as well as an Id. At least two employees should have the first name "Joe".*/

        static void Main(string[] args)

        {
            Employee employee = new Employee();
            List<Employee> empList = new List<Employee>()
            {
                new Employee {FirstName= "Joe", LastName= "Schmo", EmployeeID= 1},
                new Employee {FirstName= "Louise", LastName= "Klein", EmployeeID= 2},
                new Employee {FirstName= "Sylvia", LastName= "Lean", EmployeeID= 3},
                new Employee {FirstName= "Joe", LastName= "Stalin", EmployeeID= 4},
                new Employee {FirstName= "Priscilla", LastName= "Presley", EmployeeID= 5},
                new Employee {FirstName= "Griffin", LastName= "Burns", EmployeeID= 6},
                new Employee {FirstName= "Jessica", LastName= "Rabbit", EmployeeID= 7},
                new Employee {FirstName= "Selena", LastName= "Miku", EmployeeID= 8 },
                new Employee {FirstName= "Jessica", LastName= "Rabbit", EmployeeID= 9},
                new Employee {FirstName= "Morgan", LastName= "Le Fay", EmployeeID= 10 }
            };
           
            /*2.  Using a foreach loop, create a new list of all employees with the first name "Joe".*/

            foreach (Employee worker in empList)
            {
                worker.SayName();
            }
            Console.ReadLine();

            //Find the Joes
            List<Employee> JoeList = new List<Employee>();
            foreach (Employee personList in empList)
            {
                if (personList.FirstName == "Joe")
                {
                    JoeList.Add(personList);
                }
            }
            foreach (Employee personList in JoeList)
            {
                personList.SayName();
            }
            Console.ReadLine();

            /*3. Do the same thing again, but this time with a lambda expression.*/

            List<Employee> classList = empList.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee personList in classList)
            {
                personList.SayName();
            }
            Console.ReadLine();

            /*4. Using a lambda expression, make a list of all employees with an Id number greater than 5.*/

            List<Employee> id5List = empList.Where(x => x.EmployeeID > 5).ToList();
            foreach (Employee personList in id5List)
            {
                personList.SayName();
            }
            Console.ReadLine();
        }
    }
}


