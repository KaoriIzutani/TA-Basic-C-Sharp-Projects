using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        //    int[] testScores = { 98, 99, 85, 70, 83, 34, 91, 90, 94 };

        //    for (int i = 0; i < testScores.Length; i++) /*1. You need to set the starting value here. Typically, 
        //      starting value is 0, but sometimes you may want to set it to 1. You can name the starting value 
        //      whatever you want, but here we call it "i".
        //    2. After the 1st semicolon, you need to tell it how long you want the for loop to go on for. For this, we'll
        //    iterate the length (elements. Elements in this case are the test score numbers) of the testScores.
        //    3. After the 2nd semicolon, you need to tell what to do each time the for loop runs. In this case, it will
        //    add 1 to the array (i++).*/
        //    {
        //        if(testScores[i] > 85)
        //        {
        //        Console.WriteLine("Passing test score: " + testScores[i]);
        //        }
        //    }
        //Console.ReadLine();

        string[] names = { "Kaori", "Eric", "Adam", "Daniel" };

        //for (int j = 0; j < names.Length; j++)
        //{
        //    Console.WriteLine(names[j]); /*This displays all of the elements in the string array called "names"*/
        //}
        //Console.ReadLine();

        //List<int> testScores = new List<int>(); /*new function initiates a list, which is an instance of
        //an object. You tend to use lists more than arrays*/

        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(81);
        //testScores.Add(72);
        //testScores.Add(70);
        //testScores.Add(16);

        //foreach (int score in testScores) /*"score" is a var name. With foreach loops, try to name your variables 
        //    that are meaningful*/
        //{
        //    if (score > 85) /*If you don't put this conditional loop, you will list every test score. You only 
        //     want to list the passing scores*/
        //    {
        //        Console.WriteLine("Passing test score:" + score);
        //    }

        //}

        //Console.ReadLine();

        //List<string> names = new List<string>() { "Kaori", "Erik", "Adam", "Daniel" };

        //foreach (string name in names)
        //{

        //    Console.WriteLine(name);

        //}
        //Console.ReadLine();

        List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 60 };
        List<int> passingScores = new List<int>(); /*Creates a new list called "passingScores" with nothing in it*/

        foreach (int score in testScores)
        {
            if (score > 86)
            {
                passingScores.Add(score);
            }

        }

        Console.WriteLine(passingScores.Count);/*.Count is similar to the .Length property of an array, except .Count
        is for lists*/
        Console.ReadLine();


        /*More practice with for and foreach loop*/
        int[] array = new int[5];
        array[0] = 1;
        array[1] = 10;
        array[2] = 1000;
        array[3] = 10000;
        array[4] = 100000;

        //for (int index = 0; index < array.Length; index++)
        //{
        //    Console.WriteLine(array[index]);
        //}
        //Console.ReadLine();

        foreach (var element in array) /*The reason var is used is if you're not sure what kind of data type is in 
        the array or list. Difference between for and foreach loop? When you don't care about finding out about the
        index and where you're at now (you just want to go from start to finish), use a foreach loop. With foreach,
        you only need to declare the var and point it to which list or array you want to go through. No conditions 
        or incrementers (like i++) are needed in a foreach loop.*/
        {
            Console.WriteLine(array[element]);
        }

    }
}

