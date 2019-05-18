using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
   public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand) /*Dealer has a behavior or method called "Deal" to deal out
            cards into the deck*/
        {
            Hand.Add(Deck.Cards.First());/*"Add" is a built in method for lists. ".First" takes the first item 
            from that list.*/
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            Deck.Cards.RemoveAt(0); /*"RemoveAt" is a method for lists, where you pass in an index where you
            want to remove something.*/

            /*General rule of thumb when to inherit a class vs creating a property in a class is to use 
             * the "is/has" relationship. 21 or Blackjack is a game, so you inherit Game into TwentyOneGame.
             * A dealer has a hand, so you don't inherit from the Deck class. So you set it as a property of 
             * the Dealer class.*/
        }

    }
}
