﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise
{
    /*3. Create another class called Employee and have it inherit from the Person class. Give the Employee class a 
     * property called Id and have it be of data type int.*/
    class Employee: Person
    {
        public int Id { get; set; }
    }
}
