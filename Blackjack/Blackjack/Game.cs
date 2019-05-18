using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
   public abstract class Game /*If you create an abstract or base class, you can no longer instantiate an 
        object in your Main program from this class.*/
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }


        public abstract void Play(); /*This is an abstract method, not a property. It looks confusing, because
        //it looks like you set up a property, but you're not. All this says is if any class inherits this
        //class, it MUST implement this method. Think of it as a contract between this class and the inheriting
        //class.*/
        public virtual void ListPlayers() /*Void keyword does not return anything. In this instance, it prints 
            a list of players. A virtual method has implementation.*/
        {
            foreach (string player in Players )
            {
                Console.WriteLine(player);
            }
        }
    }
}
