using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
   public class Player
    { 
        /*Put your constructor here, at the top of your class*/
        public Player (string name, int beginningBalance) /*Takes 2 arguments, name w/ string data type and 
            beginningBalance with int data type*/
        {
            Hand = new List<Card>();
            Name = name;
            Balance = beginningBalance;
           
        }
        private List<Card> _hand = new List<Card>();
        public List<Card>/*<T>*/Hand { get { return _hand; } set { _hand = value; } } /*The use of generics 
        comes into play here. What if the player wants to play roulette or craps? These games don't have cards or a hand. 
        We're trying to avoid writing a new class, as we have created a lot of classes at this point (Step 130). 
        To create a generic list, instead of entering a data type or class, just enter T in the brackets.*/
        public int Balance { get; set; } /*Quick action: Typing "prop, then Tab, Tab", quickly sets up an 
        object's property.*/
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough funds to place that bet.");
                return false;
            }
            else
            {
                Balance -= amount; /*Shorthand of "Balance = Balance - amount;"*/
                return true;
            }
        }
        public static Game operator +(Game game, Player player) /*This is an instance of operator overloading. 
            The syntax is the return type (Game), "operator+", then in your parameters, what are you adding 
            together.*/

        {
            game.Players.Add(player); /*This method adds a player. Conversely, with the subtract operator 
            overloading, we're taking away a player.*/
            return game; /*We want to affect the "game" object, so that's why we're returning "game".*/
        }
        public static Game operator -(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
