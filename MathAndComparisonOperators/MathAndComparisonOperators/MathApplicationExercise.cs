using System;

namespace MathAndComparisonOperators
{
    class MathApplicationExercise
    {
        public static void NotMain(string[] args)
        {
            //1.
            Console.WriteLine("This multiplies whatever number you entered by 50.");
            Console.WriteLine("Enter a number up to 13 digits long: ");
            string userInput = Console.ReadLine();
            double firstNumber = Convert.ToDouble(userInput), secondNumber = 50.00, result;

            result = firstNumber * secondNumber;
            Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, result);
            Console.ReadLine();

            //2.
            Console.WriteLine("This adds whatever number you entered by 25.");
            Console.WriteLine("Enter a number up to 13 digits long: ");
            string userInput2 = Console.ReadLine();
            double Number1 = Convert.ToDouble(userInput2), Number2 = 25.00, result2;

            result2 = Number1 + Number2;
            Console.WriteLine("{0} + {1} = {2}", Number1, Number2, result2);
            Console.ReadLine();

            //3.
            Console.WriteLine("This divides whatever number you entered by 12.5.");
            Console.WriteLine("Enter a number up to 13 digits long: ");
            string userInput3;
            userInput3 = Console.ReadLine();
            double Number3 = 12.5, Number4 = Convert.ToDouble(userInput3), result3;

            result3 = Number3 / Number4;
            Console.WriteLine("{0} / {1} = {2}", Number3, Number4, result3);
            Console.ReadLine();

            //4.
            Console.WriteLine("This checks if a whole number you entered is greater than 50.");
            Console.WriteLine("Enter a number up to 10 digits long: ");
            string userInput4 = Console.ReadLine();
            int a = Convert.ToInt32(userInput4), b = 50;

            if (a > b)
            {
                Console.WriteLine(userInput4 + " is greater than 50");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine(userInput4 + " is either equal to or less than 50");
                Console.ReadLine();
            }

                //5. 
                Console.WriteLine("This checks if a whole number you entered has a remainder after dividing by 7.");
                Console.WriteLine("Enter a number up to 10 digits long: ");
                string userInput5 = Console.ReadLine();
                int remainder = Convert.ToInt32(userInput5) % 7;
                Console.WriteLine(remainder);
                Console.ReadLine();
            }
        }
    }

