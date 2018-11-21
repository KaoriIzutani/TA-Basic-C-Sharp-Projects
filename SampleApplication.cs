using System; //"Using" tells the compiler you'll use a library of pre-written code called "System"
class SampleApplication /*Tells the compiler that anything between the curly braces is part of a class called
"SampleApplication"*/
{
 static void Main() /*"Main()" tells the compiler to exec anything between the curly braces. For a console 
app, the "Main()" function auto executes as the 1st step in running the program.*/

/*"Static" is a modifier for the "Main()" function. Tells the compiler this function can be called without having
 to do anything extra (some functions require preliminary steps before they can be called.*/

/*"Void" is another modifier for the "Main()" function. Tells the compiler that this function won't return a
value. It's just going to do something, such as print words.*/

 {
  Console.WriteLine("Hello, World!"); //C# instruction telling the console to print "Hello, World!"
   }
}
