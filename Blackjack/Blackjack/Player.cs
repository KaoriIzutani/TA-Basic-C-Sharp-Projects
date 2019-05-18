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
    }
}
