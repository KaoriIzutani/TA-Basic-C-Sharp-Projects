using System;


namespace Exception_Handling
{
    public class FirstClass
    {
        static void Main(string[] args)
        {
            try /*A try/catch statement is useful for catching bugs or errors in your program.*/
            {
                Console.WriteLine("Pick a number: ");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number: ");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
                Console.ReadLine();
            }
            catch (FormatException ex) /*What this is doing is creating a var named ex. In this case, we're trying to 
                        catch formatting exception errors. For instance, a string was entered, instead of an int.*/
            {
                Console.WriteLine("Please type in a whole number. ");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex) /*What happens if the exception error is neither of the above? You can create a 
                        general exception.*/
            {
                Console.WriteLine(ex.Message);
            }
            finally /*The purpose of "finally" is to still execute something, even if an exception message pops up.
                        Also, if you put something like "break" or "return", you stop the execution of the program, which is 
                        a problem*/
            {
                Console.ReadLine();
            }

        }

    }
}
