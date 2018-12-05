using System;


namespace Step_21 //Adds a layer of organization for your code. This is above "class", which is another way
    //to organize code. C# code can get complicated and namespaces make it easier to remember where 
    //things are.
{
    class Program /*An organized grouping of code. Also is used to define specific ways that the data 
        works together.*/
    {
        static void Main() 
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            Console.Read(); //Stops the window from closing until you hit enter.
        }
    }
}
