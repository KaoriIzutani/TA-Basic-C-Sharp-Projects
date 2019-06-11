using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Append_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Pick a number: ");
           int pickedNumber= Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Your chosen number is " + "\n" + pickedNumber);
            using (StreamWriter file = new StreamWriter(@"C:\Users\Student\Desktop\All Projects\C#\numbers.txt",
                true))
            {
                file.WriteLine("Your chosen number is " + "\n" + pickedNumber);
                file.Close();
            }
            
                Console.ReadLine();
        }
    }
}
