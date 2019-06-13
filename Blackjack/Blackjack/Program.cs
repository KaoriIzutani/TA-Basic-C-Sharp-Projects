
using System;
using System.Collections.Generic;
<<<<<<< Updated upstream
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
using System.IO; /*This System.IO writes to a text file (with WriteAllText). You may be asked to do this sometimes 
in real life work.*/
using Casino;
using Casino.Blackjack;
>>>>>>> Stashed changes

namespace Blackjack /*A way to organize and tightly control your code*/
{
    class Program
    {
        static void Main(string[] args)
<<<<<<< Updated upstream

        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
=======
        {
            const string casinoName = "Kow's Hotel and Casino";
            //Guid identifier = Guid.NewGuid(); /*SQL also has a Guid method.*/
            
            // string text = File.ReadAllText(@"C:\Users\Student\Desktop\All Projects\C#\log.txt");
            //var newDictionary = new Dictionary<string, string>();
            //var newPlayer = new Player("Kaori"); /*Rule of thumb when to use var when creating variables:
            //If the data type is questionable, obscured by a lambda expression or is a very long data type
            //(like a dictionary), use var. Don't constantly use var though--makes code hard to read. */

            Console.WriteLine("Welcome to {0}. Let's start by telling me your name.", casinoName);
>>>>>>> Stashed changes
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join in on a game of Blackjack right now?",
                playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah"|| answer == "y"|| answer == "ya")
            {
                Player player = new Player(playerName, bank);/*You need to put the variables you created above 
                (takes 2 arguments per the Player class) between the parenthesis or you will get an error message.*/
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\Student\Desktop\All Projects\C#\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }

                Game game = new TwentyOneGame(); /* Step 121. This instantiation does not throw an error. It's 
             because of something called "polymorphism". A TwentyOneGame object can "morph" into another higher 
             order object, "Game". By higher order, TwentyOneGame inherits from "Game". The purpose of polymorphism
             is to incorporate several different objects (in this case, card games like poker) into the list, even
             though they are technically different data types. Simply put, it's the ability of a class to change or 
             morph into in an inheriting class.*/
                
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thanks for playing!");
            }
            /*An else statement is unnecessary in this case after the if statement*/
            Console.WriteLine("Feel free to look around the casino. Bye for now!");
            Console.Read();

            //Card card1 = new Card();
            //Card card2 = card1;
            //card1.Face = Face2.Two;
            //card2.Face = Face2.King;

            //Console.WriteLine(card1.Face);/*How come the result of this was "King" and not "Two"? Because 
            // when we assigned var card2 to card1, we didn't actually create a new object (aka assign a 
            // separate block of memory or copy). What we did was give(aka reference) card2 the address to the
            // memory location of card1. You are creating your own custom data type.*/

            // /*An analogy would be instead of emailing your teacher a copy of your drill (instantiating a new 
            //  * object), you put it up (reference with) on Google Drive, which is a shared cloud service.
            //  * This is how classes (whether you created it yourself or it was pre-built into the C# framework
            //  * library) operate in C#, by reference. If you want to make the "card1.Face" to show up as "Two", 
            //  * then you need to change the class type to "struct" (as in "public struct" Card.*/


            //int underlyingValue = (int)Suit2.Diamonds; /*We casted "Suit2.Diamonds" to an int in this example.
            //Or if you feel more comfortable, "Convert.ToInt32(Suit.Diamonds)" is another way to cast it in the 
            //same way.*/
            //Console.WriteLine(underlyingValue);

      

            Deck deck = new Deck(); /*This is how you instantiate your class.*/


            //int timesShuffled = 0;
            //deck.Shuffle(deck,out timesShuffled);

            ///* deck = Shuffle(deck: deck);*/ /*This is where you called the method "Shuffle".
            // //    You actually reassigned the var deck under the method Shuffle. Also you named your 
            // //    parameters "deck". Named parameters are handy, because they make your code 
            // //    easier to read. */
            // /*deck = Shuffle(deck, 2);*/ //This calls a method where the deck is shuffled 2 times. See line
            //                                41 on how to initialize this method.*/                                       



            //    /* Card cardOne = new Card();*/ /*Creating (or initializing) a new card object here. You need
            // to create a class first, before creating your object in your main program.*/
            //cardOne.Face = "Queen"; /*Assigning values to the card.*/
            //cardOne.Suit = "Spades";
            /*Card cardTwo = new Card() { Face = "King", Suit = "Diamonds" }; /*Here's a similar thing as above, 
             * but not as much typing. Similiar to how you initialize a list or array.*/
            ////    //deck.Cards = new List<Card>(); /*Deck has a property called Cards. Then a new list was 
            ///created with data type, List<Card>*/

            /*deck.Cards.Add(cardTwo); /*Now, you've added one card to the deck. This is one way to add cards,
            but it's tedious, since you have to repeat it 51 more times. See the Deck.cs class on how to create
            a constructor to save time.*/

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);

            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.WriteLine("Times shuffled: {0}", timesShuffled);/*{0} is a placeholder. You 
            //      * have to specify after the comma what var you want to place hold the input on. You can 
            //      * use more than one placeholder, like {1}, {2} etc.*/
            Console.ReadLine();
            /*When debugging code, a quick way to remove all breakpoints is to hit Ctrl + Shift + F9.*/

            /*If you ever want to see if your program will run without running it, you can Build it instead
             * with Ctrl + Shift + B*/
<<<<<<< Updated upstream
            }
=======

            /*More debugging tricks. If you want to go through every line of code to help with understanding it, 
             * put a breakpoint at the start of the program or class. Then use F11 (Step Into) to go through every
             * part of the code.*/

        }
>>>>>>> Stashed changes



           
        }
    }

