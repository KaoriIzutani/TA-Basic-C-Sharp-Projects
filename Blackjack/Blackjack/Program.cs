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
            Deck deck = new Deck(); /*This is how you substantiate your class.*/
            int timesShuffled = 0;
            deck = Shuffle(deck, out timesShuffled, 3);
            /*deck = Shuffle(deck: deck, times: 3);*/ /*This is where you called the method "Shuffle".
            You actually reassigned the var deck under the method Shuffle. Also you named your 
            parameters "deck" and "times". Named parameters are handy, because they make your code easier to 
            read. */
           /* deck = Shuffle(deck, 2);*/ /*This calls a method where the deck is shuffled 2 times. See line 41
            * on how to initialize this method.*/

           //deck.Cards = new List<Card>(); /*Deck has a property called Cards. Then a new list was created with
           //data type, List<Card>*/

           Card cardOne = new Card(); /*Creating (or substantiating) a new card object here. You need to create 
            a class first, before creating your object in your main program.*/
            //cardOne.Face = "Queen"; /*Assigning values to the card.*/
            //cardOne.Suit = "Spades";

            /*deck.Cards.Add(cardOne);*/ /*Now, you've added one card to the deck. This is one way to add cards, but
             * it's tedious, since you have to repeat it 51 more times. See the Deck.cs class on how to create a 
             * constructor to save time.*/

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);

            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times shuffled: {0}", timesShuffled);
            Console.ReadLine();
        }
        /*Methods are small blocks of reusable code that do something.*/
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 3) 
            /*In the parentheses, you can specify how many times you want to Shuffle the deck. These are called
             * parameters. If you don't specify a value (in this case, "int times"), the method assumes you
             * want to Shuffle one time. Specifying a value is optional. That is known as an optional 
             * parameter.*/
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
                {
                timesShuffled++;
                List<Card> TempList = new List<Card>(); /*This list will store your shuffled items*/
                Random random = new Random(); /*This Random class randomizes the deck*/

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count); /*Here, you're determining how far
                you want the random numbers to count. In this case, you'll count the deck of cards(52),
                until it goes down to 0*/
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);

                }
                deck.Cards = TempList;

            }
            
            return deck;
        }

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
