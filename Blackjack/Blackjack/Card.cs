using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
   public struct Card /*This class was created by right clicking the project name in Solution Explorer-->Add-->
        Class. Follow the prompts. We named this class, Card, for this project. General good practice is to keep
        to one class per project.*/
    {
        
        public Suit2 /*After creating the Suit enum, data type is no longer the generic "string".
        Data type was updated to "Suit2". You also need to update Face property to data type "Face2"*/ 
        Suit { get; set; } /*Here, you created a property of the Card class. 
        Analogy of a class (design for an object) vs object would be, a class is a recipe, while object is the 
        food actually created, cooked and eaten. */
        public Face2 Face { get; set; }

        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    }

    /*Put your enums here, below where you set the properties*/
    public enum Suit2
    {
        Clubs, /*Like an array, this "Clubs" has an implicit value of 0. Then "Diamonds" is 1,
        "Hearts" is 2,"Spades" is 3. You can change the value of the enums if you want.*/
        Diamonds, 
        Hearts,
        Spades
    }
   

    public enum Face2
    {
        Two,
        Three,
        Four, 
        Five, 
        Six,
        Seven,
        Eight, 
        Nine,
        Ten, 
        Jack,
        Queen,
        King,
        Ace

    }
   

   
    }
    
    
