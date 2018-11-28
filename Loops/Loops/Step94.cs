using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step94.cs
{
    class MainClass
    {
        
        static void Main(string[] args)

        //1. This program simulates rolling a die, counting the number of attempts, until you roll the number 5.
        {
            Random numberGen = new Random();
            int numberOfAttempts = 0;
            int attempt = 0;
            bool i = false;
            
                     

            while (i == false) 
            {
                if (attempt == 5)
                {
                    i = true;
                    break;
                }
                attempt = numberGen.Next(1, 6);
                Console.WriteLine("You rolled a " + attempt + ".");
                numberOfAttempts++;
            }
            Console.WriteLine("It took you " + numberOfAttempts + " attempts to roll a 5. Press Enter to continue.");
            Console.ReadLine();


            //2. This program lets you enter names, according to how many times you want to enter it.

            int iCount = 0;
            int iNum = 0;
            bool j = false == (iNum < iCount);
            String sName;

            Console.WriteLine("How many names to enter?");
            iCount = Convert.ToInt32(Console.ReadLine());

             do
            {
                if (iNum == iCount)
                {
                    j = true;
                    break;

                }
                Console.WriteLine("What is the name?");
                sName = Console.ReadLine();
                Console.WriteLine("The name is " + sName + ".");
                iNum++;
            } while (j); 


            Console.ReadLine();

        }

                
        }
    }

