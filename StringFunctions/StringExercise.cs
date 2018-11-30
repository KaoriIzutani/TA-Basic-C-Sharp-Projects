using System;
using System.Text;

namespace StringFunctions
{
    class StringExercise
    {
        //1. Concatenating 3 strings:

        static void Main(string[] args)
        {
            string quote1 = "Kaori says,\"I";
            string quote2 = " want to be the best front end designer ";
            string quote3 = "in Portland, OR\".";

            Console.WriteLine(quote1 + quote2 + quote3);
            Console.ReadLine();


            //2. Convert string to uppercase:
            string school = "The Tech Academy";
            school = school.ToUpper();
            Console.WriteLine(school);
            Console.ReadLine();

            //3. Create a Stringbuilder. Build a paragraph of text, one sentence at a time:
            StringBuilder sb = new StringBuilder(50);
            sb.Insert(0, "I like the Tech Academy. ");
            sb.Append("Currently, there are campuses in Portland, Seattle and Denver. ");
            sb.Append("They offer courses, such as \nSoftware Developer, Python, Web Developer and more. ");
            sb.Append("Go to learncodinganywhere.com for more information.");


            Console.WriteLine(sb);
            Console.ReadLine();
             }
        }
    }

