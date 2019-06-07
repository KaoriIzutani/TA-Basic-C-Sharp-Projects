using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
   public class TwentyOneRules
    {
        private static Dictionary<Face2, int> _cardValues = new Dictionary<Face2, int>()
        {
            [Face2.Two] = 2,
            [Face2.Three] = 3,
            [Face2.Four] = 4,
            [Face2.Five] = 5,
            [Face2.Six] = 6,
            [Face2.Seven] = 7,
            [Face2.Eight] = 8,
            [Face2.Nine] = 9,
            [Face2.Ten] = 10,
            [Face2.Jack] = 10,
            [Face2.Queen] = 10,
            [Face2.King] = 10,
            [Face2.Ace] = 1 /*Cannot assign multiple values in a dictionary. For simplicity, the Ace will 
            be assigned to 1.*/
        };

        private static int[] GetAllHandValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face2.Ace);
            int[] result = new int[aceCount + 1];
            int value = Hand.Sum(x => _cardValues[x.Face]);
            result[0] = value;
            if (result.Length == 1) return result; /*If your if statement is just one line, you don't need
            to use the curly braces.*/
            
            for (int i = 1; i < result.Length; i++) /*We're starting this for loop at 1, because "result" 
                started at 0.*/
            {
                value += (i * 10); /*Shorthand of value = value + (i * 10)*/
                result[i] = value;
            }
            return result;
        }

        public static bool CheckForBlackjack(List<Card> Hand)
        {
            int[] possibleValues = GetAllHandValues(Hand);
            int value = possibleValues.Max();
            if (value == 21) return true;
            else return false;
        }

        public static bool IsBusted(List<Card> Hand) /*This is checking, did the player go bust?*/
        {
            int value = GetAllHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }

        public static bool ShouldDealerStay(List<Card> Hand) /*This method says that if dealer has a 
            hand totaling between 17 and 21, dealer has to stay.*/
        {
            int[] possibleHandValues = GetAllHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22)
                {
                    return true;

                }
            }
            return false;
        }

        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllHandValues(PlayerHand);
            int[] dealerResults = GetAllHandValues(DealerHand);

            int playerScore = playerResults.Where(x => x < 22).Max(); /*This lambda expression calculates the highest 
            possible score without getting busted*/
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;
        }
            
            /*General rule of thumb when using a private access modifier is: you know a method or object is 
             * only going to be used/accessed for this class and not anywhere else. When working in a team, if
             * someone else wants to use the same name, it could cause problems if you mark it as public 
             * instead of private.
             
            Also a good example of using static modifier is if you don't intend on creating objects in
            the class. You just want to store multiple methods in the class.*/

            /*Naming convention for private methods/classes is to use an underscore before the name.*/
    }
}
