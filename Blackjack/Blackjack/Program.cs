using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)

        {
            
            //game.Players = new List<string>() { "Jesse", "Gary", "Todd" };
            //game.ListPlayers();
            //Console.ReadLine();
            //List<Game> games = new List<Game>();
            /*Game game = new TwentyOneGame();*/ /* Step 121. This instantiation does not throw an error. It's 
             because of something called "polymorphism". A TwentyOneGame object can "morph" into another higher 
             order object, "Game". By higher order, TwentyOneGame inherits from "Game". The purpose of polymorphism 
             is to incorporate several different objects (in this case, card games like poker) into the list, even 
             though they are technically different data types.*/
            

            /*Simply put, it's the ability of a class to change or morph into in an inheriting class.*/

            //games.Add(game);

            //game.Play();


            Deck deck = new Deck(); /*This is how you instantiate your class.*/
            

            int timesShuffled = 0;

            /* deck = Shuffle(deck: deck);*/ /*This is where you called the method "Shuffle".
             //    You actually reassigned the var deck under the method Shuffle. Also you named your 
             //    parameters "deck" and "times". Named parameters are handy, because they make your code 
             //    easier to read. */
            /*deck = Shuffle(deck, 2);This calls a method where the deck is shuffled 2 times. See line
              41 on how to initialize this method.*/                                       

            //    //deck.Cards = new List<Card>(); /*Deck has a property called Cards. Then a new list was created 
            // with data type, List<Card>*/

            //    /* Card cardOne = new Card();*/ /*Creating (or initializing) a new card object here. You need to 
            //create a class first, before creating your object in your main program.*/
            //cardOne.Face = "Queen"; /*Assigning values to the card.*/
            //cardOne.Suit = "Spades";
            /*Card cardTwo = new Card() { Face = "King", Suit = "Diamonds" }; /*Here's a similar thing as above, but
            not as much typing. Similiar to how you initialize a list or array.*/

            //    //deck.Cards.Add(cardTwo); /*Now, you've added one card to the deck. This is one way to add cards, but
            //    // * it's tedious, since you have to repeat it 51 more times. See the Deck.cs class on how to create a 
            //    // * constructor to save time.*/

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);

            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times shuffled: {0}", timesShuffled);/*{0} is a placeholder. You 
                  * have to specify after the comma what var you want to place hold the input on. You can 
                  * use more than one placeholder, like {1}, {2} etc.*/
            Console.ReadLine();
            /*When debugging code, a quick way to remove all breakpoints is to hit Ctrl + Shift + F9.*/

            /*If you ever want to see if your program will run without running it, you can Build it instead
             * with Ctrl + Shift + B*/
            }



           
        }
    }

