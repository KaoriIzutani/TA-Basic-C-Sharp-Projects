using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Drill
{
    class Program
    {
        /*3. Instantiate an Employee object with type "string" as its generic parameter. Assign a 
         * list of strings as the property value of Things.*/

       public static void Main(string[] args)
        {
            
            Employee<string> employee = new Employee<string>
            {
                Things = new List<string> { "cup", "pen", "desk" }
            };
        /*4. Instantiate an Employee object with type "int" as its generic parameter. Assign a list
             of integers as the property value of Things & 
          5. Create a loop that prints all of the Things to the Console.*/
           

            Employee<int> id = new Employee<int>
            {
                Things = new List<int> { 25, 26, 27 }
            };

            foreach (var items in employee.Things)
            {
                Console.WriteLine(items);
                Console.ReadLine();
                
            }
            foreach (var numbers in id.Things)
            {
                Console.WriteLine(numbers);
                Console.ReadLine();

            }




        }

    }

}

