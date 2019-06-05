using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{

    interface IWalkAway /*To set up an interface, is similar to setting up a class. Except after you right click 
        Add Class, you select Interface. Unlike classes, you can inherit more than one interface. Naming convention 
        is to start the interface name with "I".*/
    {
        void WalkAway(Player player); /*Every interface is assumed to be public access, you don't have to state the
        modifier here.*/
    }
}
