using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class TwentyOneGame : Game /*This is how you inherit a class, indicated by the colon. This says that 
        TwentyOneGame is inheriting from the Game class. The purpose of inheriting a class is so you don't have 
        to repeat code in related classes.*/
    {
        public TwentyOneDealer Dealer { get; set; } /*Moved the Dealer property from the Card to the
        TwentyOneDealer class*/
        public override void Play() /*The override keyword implements the abstract method you created in the 
            Game class.*/
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>(); /*This code means that each time a new game happens, the 
                player is dealt a new hand. We are not carrying over the old hand.*/
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck(); /*This code refreshes the deck to discourage cheating*/
            int timesShuffled = 0;
            Dealer.Deck.Shuffle(Dealer.Deck, out timesShuffled); /*Here is where you'll call the shuffle method*/
            Console.WriteLine("Place your bet.");

            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet); /*The var "successfullyBet is pulling the "Bet" method 
                I created in the Player class.*/
                if (!successfullyBet) /*Shorthand for "successfullyBet == false"*/
                {
                    return; /*Even though the Play method is void (where it doesn't return
                    anything), this is telling the compiler to end the method.*/
                }
                Bets[player] = bet;
            }
            for (int i = 0; i < 2; i++) /*Going through this for loop twice.*/
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name); /*"Console.Write" is slightly different from 
                    "Console.WriteLine". "Console.Write" says write to the console, but don't press enter.
                    The next thing coming afterwards won't be on a new line.*/
                    Dealer.Deal(player.Hand);
                    if (i == 1) /*This if statement checks, did the player hit Blackjack (21) after being dealt 
                        card #2?*/
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackjack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5 + Bets[player]));
                            /*This code says if the player won, he/she not only gets the original bet back,
                             * he/she also gets 1.5 times what was bet. */
                            return;
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackjack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has Blackjack! Everyone loses.");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                    }
                }

            }

            foreach (Player player in Players)
            {
                while (!player.Stay) /*Make sure your logic says while the player is NOT (!) staying. Otherwise, you 
                    won't hit this while loop after the dealer and player's cards are dealt.*/
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\n Hit or Stay?"); /*"/n" creates a new line in the console.*/
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    try
                    {
                        if (busted)
                        {
                            Dealer.Balance += Bets[player];
                            Console.WriteLine("{0} Busted! You lost your bet of {1). Your balance is " +
                                "now {2).", player.Name, Bets[player], player.Balance);
                            Console.WriteLine("Do you want to play again?");
                            answer = Console.ReadLine().ToLower();
                            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
                            {
                                player.isActivelyPlaying = true;
                            }
                            else
                            {
                                player.isActivelyPlaying = false;
                            }
                        }
                    }

                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }


                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
                while (!Dealer.Stay && !Dealer.isBusted)
                {
                    Console.WriteLine("Dealer is hitting..");
                    Dealer.Deal(Dealer.Hand);
                    Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                    Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
                }
                if (Dealer.Stay)
                {
                    Console.WriteLine("Dealer is staying.");
                }
                if (Dealer.isBusted)
                {
                    Console.WriteLine("Dealer busted!");
                    foreach (KeyValuePair<Player, int> entry in Bets)
                    {
                        Console.WriteLine("{0} won {1}", entry.Key.Name, entry.Value); /*The "entry.Key.Name"
                    and "entry.Value" is how to access the Dictionary's key value pairs.*/
                        Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                        Dealer.Balance -= entry.Value;
                    }
                    /*This foreach loop goes through the Dictionary's key value pair where the name matches 
                     * "entry.Key.Name". The "Where" lambda function makes a list. The .First() grabs the name, 
                     * takes the player's balance and then it adds what the player bet, then multiplies it 
                     * by 2. The dealer in this case lost, so the dealer's balance gets deducted.*/
                    return;
                }


                foreach (Player player2 in Players)
                {
                    bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand); /*This question mark next 
                    to bool says this can now accept null values*/
                    if (playerWon == null)
                    {
                        Console.WriteLine("Push! No one wins."); /*This means both hands have the same total. You don't
                        win anything, but you don't lose anything either.*/
                        player2.Balance += Bets[player];

                    }
                    else if (playerWon == true)
                    {
                        Console.WriteLine("{0} wins {1}", player.Name, Bets[player]);
                        player2.Balance += (Bets[player] * 2);
                        Dealer.Balance -= Bets[player];
                    }
                    else
                    {
                        Console.WriteLine("Dealer wins {0}!", Bets[player]);
                        Dealer.Balance += Bets[player];
                    }
                    Console.WriteLine("Play again?");
                    string answer2 = Console.ReadLine().ToLower();
                    if (answer2 == "yes" || answer2 == "yeah" || answer2 == "y" || answer2 == "ya")
                    {
                        player.isActivelyPlaying = true;
                    }

                    else
                    {
                        player.isActivelyPlaying = false;
                    }
                }

            }
        }

        public override void ListPlayers()
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers(); /*Here, I typed "public override ListPlayers" and it auto-filled 
            base.ListPlayers();. This is similar to what happens in the foreach loop you created in the
            Game class".*/

        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }

    }
}

