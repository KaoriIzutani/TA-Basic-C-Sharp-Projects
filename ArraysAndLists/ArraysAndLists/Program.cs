using System;
using System.Collections.Generic;//This library collection has to do with lists.




    class Program
    {
        static void NotMain()
        {
        List<string> intList = new List<string>();
        intList.Add("I"); //"Add" and "Remove" are two properties you can use with lists
        intList.Add("love");
        intList.Add("Maine Coons.");

        Console.WriteLine(intList[2]);

        /*byte[] byteArray = new byte[5000];*//*You can store binary information, like large images
        using a "byte array".*/
        //int[] numArray = new int[5]; /*When you create a new object (in this case, an array), you
        //must specify how long the array is going to be between the brackets.*/
        //numArray[0] = 5; //You could write the code like this, but it's inefficient.
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 }; /*When you set up your variable, 
        //this is a much more efficient way of writing your array.*/

        int[] numArray2 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        numArray2[5] = 640;//This lets you change the int value in array 5 to 640.


        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();

        /*So if you want to make it, so the number pops up according to what index number 
        user has typed up, you need to do this: Create another int variable (in this 
        example, it's called "UserIndex"),cast it with Convert.ToInt32, then refer back to 
        the array you created and in the brackets, type in the 2nd var you created. */

        int[] intArray1 = new int[4] { 20, 19, 68, 400 };
        int UserIndex = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(intArray1[UserIndex]);

    }
    }

