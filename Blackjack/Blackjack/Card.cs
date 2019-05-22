using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
   public class Card /*This class was created by right clicking the project name in Solution Explorer-->Add-->Class.
        Follow the prompts. We named this class, Card, for this project. General good practice is to keep to one class per
        project.*/
    {
        
            public Card()
            {
                Suit = "Spades";
                Face = "Two";
            }
        
        public string Suit { get; set; } /*Here, you created a property of the Card class. Analogy of a class (design
        for an object) vs object would be, a class is a recipe, while object is the food actually created, cooked and 
        eaten. */
        public string Face { get; set; }
    }
    }
    
