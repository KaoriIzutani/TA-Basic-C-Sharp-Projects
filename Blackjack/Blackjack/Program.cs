using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)


        {
<<<<<<< HEAD
=======
            Card card1 = new Card();
            Card card2 = card1;
            card1.Face = Face2.Two;
            card2.Face = Face2.King;
          
           Console.WriteLine(card1.Face);/*How come the result of this was "King" and not "Two"? Because 
           // when we assigned var card2 to card1, we didn't actually create a new object (aka assign a 
           // separate block of memory or copy). What we did was give(aka reference) card2 the address to the
           // memory location of card1. You are creating your own custom data type.*/

           // /*An analogy would be instead of emailing your teacher a copy of your drill (instantiating a new 
           //  * object), you put it up (reference with) on Google Drive, which is a shared cloud service.
           //  * This is how classes (whether you created it yourself or it was pre-built into the C# framework
           //  * library) operate in C#, by reference. If you want to make the "card1.Face" to show up as "Two", 
           //  * then you need to change the class type to "struct" (as in "public struct" Card.*/
          

            int underlyingValue = (int)Suit2.Diamonds; /*We casted "Suit2.Diamonds" to an int in this example.
            Or if you feel more comfortable, "Convert.ToInt32(Suit.Diamonds)" is another way to cast it in the 
            same way.*/
            Console.WriteLine(underlyingValue);

            Console.WriteLine(card1.Face);
            
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Gary", "Todd" }; 
            //game.ListPlayers();
            //Console.ReadLine();
            //List<Game> games = new List<Game>();
            Game game = new TwentyOneGame(); /* Step 121. This instantiation does not throw an error. It's 
             because of something called "polymorphism". A TwentyOneGame object can "morph" into another higher 
             order object, "Game". By higher order, TwentyOneGame inherits from "Game". The purpose of polymorphism
             is to incorporate several different objects (in this case, card games like poker) into the list, even
             though they are technically different data types.*/
          
           /*Simply put, it's the ability of a class to change or morph into in an inheriting class.*/
>>>>>>> c57892720e30a08a7c61eaeba2be46586ef383b5

            //Card card1 = new Card(); /*To peek under the hood of a class or object, highlight the class
            //or object, right click and select "Go to Definition" (F12)*/
            //Card card2 = card1; 
            //card1.Face = Face2.Two;
            //card2.Face = Face2.King;

            ///* Console.WriteLine(card1.Face);*/ /*How come the result of this was "King" and not "Two"? Because 
            // when we assigned var card2 to card1, we didn't actually create a new object (aka assign a 
            // separate block of memory or copy). What we did was give(aka reference) card2 the address to the
            // memory location of card1. You are creating your own custom data type.*/

            // /*An analogy would be instead of emailing your teacher a copy of your drill (instantiating a new 
            //  * object), you put it up (reference with) on Google Drive, which is a shared cloud service.
            //  * This is how classes (whether you created it yourself or it was pre-built into the C# framework
            //  * library) operate in C#, by reference. If you want to make the "card1.Face" to show up as "Two", 
            //  * then you need to change the class type to "struct" (as in "public struct" Card.*/

            //int underlyingValue = (int)Suit2.Diamonds; /*We casted "Suit2.Diamonds" to an int in this example.
            //Or if you feel more comfortable, "Convert.ToInt32(Suit.Diamonds)" is another way to cast it in the 
            //same way.*/
            //Console.WriteLine(underlyingValue);

            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Gary", "Todd" }; 

            //game.ListPlayers();
            //Console.ReadLine();
            //List<Game> games = new List<Game>();
            /*Game game = new TwentyOneGame();*/ /* Step 121. This instantiation does not throw an error. It's 
             because of something called "polymorphism". A TwentyOneGame object can "morph" into another higher
             order object, "Game". By higher order, TwentyOneGame inherits from "Game". The purpose of polymorphism 
             is to incorporate several different objects (in this case, card games like poker) into the list, even 
             though they are technically different data types.*/



            Deck deck = new Deck(); /*This is how you instantiate your class.*/


            //int timesShuffled = 0;
            //deck.Shuffle(deck,out timesShuffled);

<<<<<<< HEAD
            Deck deck = new Deck(); /*This is how you instantiate your class.*/
           //List<Card> newList = deck.Cards.Where(x => x.Face == Face2.King).ToList(); /*This means
          //take the list of cards, find out which faces equal "King", then map it to a new list.*/

            //int counter = 0;
            //foreach (Card card in deck.Cards)
            //{
            //    if (card.Face == Face2.Two)
            //    {
            //        counter++;
            //    }

            //}
            //Console.WriteLine(counter);

            //int count = deck.Cards.Count(x => x.Face == Face2.Two); /*A shorter way to write the above 
            //expression, using a lambda expression.*/
            //Console.WriteLine(count);

            //List<Card> newList = deck.Cards.Where(x => x.Face == Face2.King).ToList(); /*The "Where" lambda 
            //function is similar to SQL's WHERE function to filter through the list. You have to include the
            //".ToList();" or otherwise you get an error.*/
            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}



            List<int> numberList = new List<int>() { 6, 776, 9, 53, 342, 19 };
           /* int sum = numberList.Min( x=> x + 5);*/ /*This lambda expression says for each element or item,
            //(represented by x), add 5 to it.*/
           numberList.Sum();/*"numberList.Max" is the highest number on the list. "numberList.Min" is the 
            //lowest number.*/
            int sum = numberList.Where(x => x > 20).Sum(); /*This is an example of concatenating the Where and
          //Sum lambda methods. Learn lambda expressions. They help with your coding speed and efficiency! 
            //However, a word of caution. If something goes wrong with your lambda expression, it's harder to 
            //debug. Because with lambdas, you can't step through it to find out what's wrong. Also, try not to 
            //chain too many lambdas or it makes your code hard to read.*/
            Console.WriteLine(sum);
            Console.ReadLine();

            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}

            //int count = deck.Cards.Count(x => x.Face == Face2.Ace); /*This is an example of a lambda 
            //expression (Step 138). It is counting all the elements (represented by x. You can name 
            //the elements anything you want, but x is standard naming), where "x.Face 
            //are Aces.*/
            //Console.WriteLine(count);

            //int timesShuffled = 0;
            //deck.Shuffle(deck, out timesShuffled);


            ///* deck = Shuffle(deck: deck);*/ /*This is where you called the method "Shuffle".
            // //    You actually reassigned the var deck under the method Shuffle. Also you named your 
            // //    parameters "deck" and "times". Named parameters are handy, because they make your code 
            // //    easier to read. */
            ////deck = Shuffle(deck, 2); /*This calls a method where the deck is shuffled 2 times.*/



            ////    /* Card cardOne = new Card();*/ /*Creating (or initializing) a new card object here. You need to 
            ////create a class first, before creating your object in your main program.*/
            ////cardOne.Face = "Queen"; /*Assigning values to the card.*/
            ////cardOne.Suit = "Spades";
            ///*Card cardTwo = new Card() { Face = "King", Suit = "Diamonds" }; /*Here's a similar thing as above, but
            //not as much typing. Similiar to how you initialize a list or array.*/
            //////    //deck.Cards = new List<Card>(); /*Deck has a property called Cards. Then a new list was created 
            ////// with data type, List<Card>*/


            //////    /* Card cardOne = new Card();*/ /*Creating (or initializing) a new card object here. You need 
            //////to create a class first, before creating your object in your main program.*/
            //////cardOne.Face = "Queen"; /*Assigning values to the card.*/
            //////cardOne.Suit = "Spades";
            //////Card cardTwo = new Card() { Face = "King", Suit = "Diamonds" }; /*Here's a similar thing as above, 
            /////but not as much typing. Similiar to how you initialize a list or array*/

            //////    //deck.Cards.Add(cardTwo); /*Now, you've added one card to the deck. This is one way to add cards, but
            //////    // * it's tedious, since you have to repeat it 51 more times. See the Deck.cs class on how to create a 
            //////    // * constructor to save time.*/
=======
            ///* deck = Shuffle(deck: deck);*/ /*This is where you called the method "Shuffle".
            // //    You actually reassigned the var deck under the method Shuffle. Also you named your 
            // //    parameters "deck". Named parameters are handy, because they make your code 
            // //    easier to read. */
            // /*deck = Shuffle(deck, 2);*/ //This calls a method where the deck is shuffled 2 times. See line
            //                                41 on how to initialize this method.*/                                       

            ////    //deck.Cards = new List<Card>(); /*Deck has a property called Cards. Then a new list was created 
            //// with data type, List<Card>*/
            

            /* deck = Shuffle(deck: deck);*/ /*This is where you called the method "Shuffle".
             //    You actually reassigned the var deck under the method Shuffle. Also you named your 
             //    parameters "deck" and "times". Named parameters are handy, because they make your code 
             //    easier to read. */
            //deck = Shuffle(deck, 2); /*This calls a method where the deck is shuffled 2 times.*/
                                    

        
            //    /* Card cardOne = new Card();*/ /*Creating (or initializing) a new card object here. You need to 
            //create a class first, before creating your object in your main program.*/
            //cardOne.Face = "Queen"; /*Assigning values to the card.*/
            //cardOne.Suit = "Spades";
            /*Card cardTwo = new Card() { Face = "King", Suit = "Diamonds" }; /*Here's a similar thing as above, but
            not as much typing. Similiar to how you initialize a list or array.*/
            ////    //deck.Cards = new List<Card>(); /*Deck has a property called Cards. Then a new list was created 
            //// with data type, List<Card>*/



            ////    /* Card cardOne = new Card();*/ /*Creating (or initializing) a new card object here. You need 
            ////to create a class first, before creating your object in your main program.*/
            ////cardOne.Face = "Queen"; /*Assigning values to the card.*/
            ////cardOne.Suit = "Spades";
            ////Card cardTwo = new Card() { Face = "King", Suit = "Diamonds" }; /*Here's a similar thing as above, 
            ///but not as much typing. Similiar to how you initialize a list or array*/

            ////    //deck.Cards.Add(cardTwo); /*Now, you've added one card to the deck. This is one way to add cards, but
            ////    // * it's tedious, since you have to repeat it 51 more times. See the Deck.cs class on how to create a 
            ////    // * constructor to save time.*/
>>>>>>> c57892720e30a08a7c61eaeba2be46586ef383b5

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);

            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.WriteLine("Times shuffled: {0}", timesShuffled);/*{0} is a placeholder. You 
            //      * have to specify after the comma what var you want to place hold the input on. You can 
            //      * use more than one placeholder, like {1}, {2} etc.*/
<<<<<<< HEAD

=======
            Console.ReadLine();
>>>>>>> c57892720e30a08a7c61eaeba2be46586ef383b5
            /*When debugging code, a quick way to remove all breakpoints is to hit Ctrl + Shift + F9.*/

            /*If you ever want to see if your program will run without running it, you can Build it instead
             * with Ctrl + Shift + B*/
        }



           
        }
    }

