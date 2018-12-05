using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        /*1. Create an array of strings. Ask the user to select an index of the array, then 
         display the string at that index of the screen.*/

        string[] strArray1 = new string[3] { "January", "February", "March" };
        Console.WriteLine("Type an index number, from 0 to 2.");
        int MonthIndex = Convert.ToInt32(Console.ReadLine());


        for (int i = 0; i < strArray1.Length; i++)
        {
            if (i == MonthIndex)
            {
                Console.WriteLine("The index points to the month of " + strArray1[i]);
                Console.ReadLine();
            }

        }


        /*2. Create an array of integers. Ask the user to select an index of the array, then 
          display the integer at that index of the screen.*/

        int[] intArray1 = new int[4] { 20, 19, 68, 400 };
        Console.WriteLine("Type an index number, from 0 to 3.");
        int UserIndex = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(intArray1[UserIndex]);
        Console.ReadLine();

        /*3. Add in a message which displays when the user selects an index that does not 
         exist.*/
        int[] intArray2 = new int[5] { 26, 32, 438, 5000, 10 };
        Console.WriteLine("Type an index number, from 0 to 4.");
        int UserIndex2 = Convert.ToInt32(Console.ReadLine());



        if (UserIndex2 <= 4 && UserIndex2 >= 0)
        {
            Console.WriteLine("The index you picked has a number of " + intArray2[UserIndex2]);
            Console.ReadLine();


        }
        else
        {
            Console.WriteLine("That is an invalid index number. Please enter an index number between 0 to 4.");
            Console.ReadLine();

        }


        /*4. Create a list of strings. Ask the user to select an index of the list, then 
         display the content at that index of the screen*/

        List<string> XmasWishList = new List<string>();
        XmasWishList.Add("sturdy socks.");
        XmasWishList.Add("a warm scarf.");
        XmasWishList.Add(" a new laptop.");
        XmasWishList.Add("chocolate candy!");

        Console.WriteLine("Select a number from 0 to 3.");

        int XmasGift = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You got a Christmas gift of " + XmasWishList[XmasGift]);
        Console.ReadLine();

     }
}
    

