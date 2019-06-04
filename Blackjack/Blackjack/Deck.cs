using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
   public class Deck
    {
        public Deck()/*You're creating a constructor (a method that is called when an object is 
            created) here and naming it the same as your class, Deck*/
        {
            Cards = new List<Card>(); /*Cards refers to the property of the class Deck. You don't need to name 
            a var or give it a data type, because Cards is a property of the object or class. So far, this is an 
            empty list or it's not substantiated yet.*/

            for (int i = 0; i < 13; i++) /*This loops through all the faces we created in the Card class.*/
            {
                for (int j= 0; j < 4; j++) /*This loops through all the suits we created in the Card class.*/
                {
                    Card card = new Card();
                    card.Face = (Face2)i;
                    card.Suit = (Suit2)j;
                    Cards.Add(card);
                }
            }


            //foreach (string face in Faces) /*Here, we're creating a nested foreach loop to loop through 4 times. There 
            //        are 13 faces and 4 suits, so 13 x 4 = 52 cards to create.*/
            //    {
            //        //foreach (string suit in Suits)
            //        //{
            //        //    Card card = new Card(); /*Creates a new, blank card*/
            //        //    card.Suit = suit; /*Assigns the card one of the four suits*/
            //        //    card.Face = face; /*Assigns the card one of 13 faces*/
            //    Cards.Add(card); /*Adds this card to the blank list called "Cards", that was 
           // created on top*/

                    //        //}
                    //    }
            }
        public List<Card> Cards { get; set; } /*Here is where you set up the Cards property*/

        public void Shuffle(Deck deck, out int timesShuffled, int times = 2)
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++;
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
            }
            
        }

    }
}
