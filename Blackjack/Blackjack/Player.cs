using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
   public class Player
    { 
        public List<Card> Hand { get; set; }
        public int Balance { get; set; } /*Quick action: Typing "prop, then Tab, Tab", quickly sets up an 
        object's property.*/
        public int Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        public static Game operator+ (Game game, Player player) /*This is an instance of operator overloading. 
            The syntax is the return type (Game), "operator+", then in your parameters, what are you adding together.*/

        {
            game.Players.Add(player); /*This method adds a player. Conversely, with the subtract operator overloading,
            we're taking away a player.*/
            return game; /*We want to affect the "game" object, so that's why we're returning "game".*/
        }
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
