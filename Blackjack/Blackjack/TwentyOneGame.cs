using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
   public class TwentyOneGame : Game /*This is how you inherit a class, indicated by the colon. This says that 
        TwentyOneGame is inheriting from the Game class. The purpose of inheriting a class is so you don't have to 
        repeat code in related classes.*/
    {
        public override void Play() /*The override keyword implements the abstract method you created in the 
            Game class.*/
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers(); /*Here, I typed "public override ListPlayers" and it auto-filled 
            "base.ListPlayers();. This is similar to what happens in the foreach loop you created in the
            Game class".*/
            

        }
    }
}
