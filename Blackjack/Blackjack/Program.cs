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
            Deck deck = new Deck();
            deck = Shuffle(deck); /*This is where you called the method "Shuffle". You actually reassigned the var
            deck under the method Shuffle.*/

            //deck.Cards = new List<Card>(); /*Deck has a property called Cards. Then a new list was created with data 
            //type, List<Card>*/

            Card cardOne = new Card(); /*Creating (or substantiating) a new card object here. You need to create a 
            class first, before creating your object in your main program.*/
            //cardOne.Face = "Queen"; /*Assigning values to the card.*/
            //cardOne.Suit = "Spades";

            /*deck.Cards.Add(cardOne);*/ /*Now, you've added one card to the deck. This is one way to add cards, but it's 
            tedious, since you have to repeat it 51 more times. See the Deck.cs class on how to create a constructor
            to save time.*/

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);

            }
            Console.WriteLine(deck.Cards.Count);
           
            Console.ReadLine();
        }
        /*Methods are small blocks of reusable code that do something.*/
        public static Deck Shuffle(Deck deck)
        {
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
            return deck;
        }
    }
}
