using System;
using System.Collections.Generic;




class Program
{

    static void Main(string[] args)
    {
        /*1. Create a one-dimensional Array of strings. Ask the user to input some text. Create a loop that goes through each
         * string in the Array, adding the user’s text to the string. Then create a loop that prints off each string in the 
         * Array on a separate line.*/

        string[] picnicItems = { "picnic basket", "sandwich", "frisbee", "towel" };


        for (int p = 0; p < picnicItems.Length; p++)
        {
            Console.WriteLine("Enter a picnic item to buy: ");
            string enteredItem = Console.ReadLine();
            Console.WriteLine("You added the following items to the list: " + enteredItem + ", " + picnicItems[p]);

        }
        Console.ReadLine();


        /*2. Create an infinite loop.*/

        int[] randomNumbers = { 13, 83, 7, 38, 92 };

        for (; ; )
        {
            Console.WriteLine(randomNumbers[2]);

        }

        Console.ReadLine();

        /*3.  Fix the infinite loop so it will execute.*/

        int[] randomNumbers = { 13, 83, 7, 38, 92 };

        for (int r = 0; r < randomNumbers.Length; r++)
        {
            Console.WriteLine(randomNumbers[2]);
        }
        Console.ReadLine();

        /*4.  Create a loop where the comparison used to determine whether to continue iterating the loop is a 
         * “<” operator.*/

        int[] moreNumbers = { 33, 42, 45, 37 };

        for (int s = 0; s < moreNumbers.Length; s++)
        {
            Console.WriteLine(moreNumbers[s]);
        }

        Console.ReadLine();

        ///*5. Create a loop where the comparison used to determine whether to continue iterating the loop is a 
        // * “<=” operator.*/

        int length = 40;
        for (int index = 1; index <= length; index++)
        {
            if (index % 2 == 1)
            {
                Console.WriteLine(index);
            }

        }

        Console.ReadLine();

        /*6. Create a List of strings where each item in the list is unique. Ask the user to select text to search for 
         * in the List. Create a loop that iterates through the list and then displays the index of the array that 
         * contains matching text on the screen.*

         * and 7. Add text code to that above loop that tells a user if they put in text that isn’t in the List.
         * 
           and 8. Add code to the above loop that stops executing once a match has been found.*/

        List<string> loginUsers = new List<string>() { "Don", "Flora", "Nina", "George", "Don", "Flora" };

        Console.WriteLine("Which name do you like best?: Don, Flora, Nina, or George?");
        string enteredUser = Console.ReadLine();


        var i = 0;
        bool nameFound = false;

        while (i < loginUsers.Count)
        {

            if (enteredUser == loginUsers[i])
            {
                nameFound = true;
                Console.WriteLine("Your entered name of " + loginUsers[i] + " has an index of " + i);
                Console.ReadLine();
            }
            i++;
        }

        if (nameFound == false)
        {
            Console.WriteLine("Sorry, that's not the right name.");
            Console.ReadLine();
        }


        /*9. Create a list of strings that has at least two identical strings in the list. Ask the user to select text to search 
         * for in the List. Create a loop that iterates through the list and then displays the indices of the array that contain
         * matching text on the screen.

        *  and 10. Add text code to that above loop that tells a user if they put in text that isn’t in the List.*/

        List<string> favColors = new List<string> { "orange", "red", "purple", "orange", "black", "teal", "white" };

        Console.WriteLine("What is your favorite color? ");
        string enteredColor = Console.ReadLine();

        var c = 0;
        bool colorFound = false;

        while (c < favColors.Count)
        {
            if (enteredColor == favColors[c])
            {
                colorFound = true;
                Console.WriteLine("The color you chose, " + favColors[c] + " has an index of " + c);
                Console.ReadLine();
            }
            c++;
        }

        if (colorFound == false)
        {
            Console.WriteLine("Unfortunately, that was not the right color.");
            Console.ReadLine();

        }


        /*11.  Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates 
         *     each item in the list, and displays a message showing the string and whether or not it has already appeared in the 
         *     list.*/

        List<string> iceCreamFlavors = new List<string> { "pistachio", "rainbow sherbet", "mint chocolate chip",
             "vanilla", "strawberry", "rainbow sherbet"};
            List<string> duplicateFlavors = new List<string>();

        
        
        foreach (string flavor in iceCreamFlavors)
        {
            if (!duplicateFlavors.Contains (flavor))
               {
                Console.WriteLine("This flavor, " + flavor + ", has not appeared on the list.");
                duplicateFlavors.Add(flavor);
               
            }
            

            else
            {
                Console.WriteLine(flavor + " is already on the list.");
            }
        }
Console.ReadLine();
    }
}
    




