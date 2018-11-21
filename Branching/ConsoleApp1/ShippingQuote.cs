using System;

public class Class1
{
	static void Main ()
	{
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        Console.WriteLine("Enter your package's weight.");
        decimal PackageWeight = Convert.ToDecimal(Console.ReadLine());
        if (PackageWeight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            Console.ReadLine();
            return;
        }
        

        Console.WriteLine("Please enter your package's width.");
        decimal PackageWidth = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Please enter your package's height.");
        decimal PackageHeight = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Please enter your package's length.");
        decimal PackageLength = Convert.ToDecimal(Console.ReadLine());
        decimal YourQuote = Convert.ToDecimal (PackageWidth + PackageHeight + PackageLength * PackageWeight / 100);
        Math.Round(YourQuote, 3);

        if (PackageWidth + PackageHeight + PackageLength > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
            Console.ReadLine();
            return;
        }
        else
        {
            Console.WriteLine("Your estimated shipping total is: " + "$" + YourQuote);
        }

        Console.ReadLine();
	}
}
