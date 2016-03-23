using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlackJack
{
    //Motor
    class Game
    {

        public void RunGame(Deck NewDeck, Player player, Dealer dealer, Betting betting, Rules rules)
        {
            bool keepPlaying = true;
            while (keepPlaying)
            {
                bool run = true;
                string hit = "1";
                NewDeck.Shuffle();
                betting.BetPlayer(betting.Bet, player._balance);
                Console.Clear();
                Console.WriteLine("Here is your first card from the dealer");
                var PlayerCard = NewDeck.DealOneCard();
                player.PlayersHand(PlayerCard.face);
                Console.WriteLine($"You've got {PlayerCard}and your currently at: {player.PlayerPoints()}\n");
                Thread.Sleep(1200);

                Console.WriteLine("Dealer gets a card");
                var DealerCard = NewDeck.DealOneCard();
                dealer.DealerHand(DealerCard.face);
                Console.WriteLine($"Dealer got {DealerCard}and is currently at: {dealer.DealerPoints()}\n");
                Thread.Sleep(1200);

                Console.WriteLine("Here is your second card from the dealer");
                PlayerCard = NewDeck.DealOneCard();
                player.PlayersHand(PlayerCard.face);
                Console.WriteLine($"You've got {PlayerCard}and your currently at: {player.PlayerPoints()}\n");
                hit = rules.PlayerBustOrNot(player.points);
                
                while (run)
                {

                    switch (hit)
                    {
                        case "1":
                            Console.WriteLine("another card?\n1.Yes\n2.No");
                            hit = Console.ReadLine();
                            if (hit == "2")
                            {
                                break;
                            }
                            PlayerCard = NewDeck.DealOneCard();
                            player.PlayersHand(PlayerCard.face);
                            Console.WriteLine($"You've got {PlayerCard}and your currently at: {player.PlayerPoints()}\n");
                            hit = rules.PlayerBustOrNot(player.points);

                            break;
                        case "2":

                            DealerCard = NewDeck.DealOneCard();
                            dealer.DealerHand(DealerCard.face);
                            Console.WriteLine($"Dealer got {DealerCard}and is currently at: {dealer.DealerPoints()}\n");
                            hit = rules.dealerstays(dealer.dealerPoints);
                            break;

                        case "3":
                            hit = rules.Winner(player.points, dealer.dealerPoints);
                            break;
                        case "4":
                            player._balance = (betting.Bet + player._balance);
                            Console.WriteLine("Your balance is now: " + player._balance);
                            hit = "6";
                            break;
                        case "5":
                            player._balance = (player._balance - betting.Bet);
                            Console.WriteLine("Your balance is now: " + player._balance);
                            hit = "6";
                            break;

                        case "6":
                            Console.WriteLine("Do you want to play again?\n1.Yes\n2.No");
                            string again = Console.ReadLine();
                            while (again != "1" && again != "2")
                            {
                                Console.WriteLine("You entered a non valid option.");
                                again = Console.ReadLine();
                            }
                            if (again == "2")
                            {
                                keepPlaying = false;
                            }                   
                            run = false;
                            hit = "8";
                            player.points = 0;
                            dealer.dealerPoints = 0;
                            NewDeck.currentCard = 0;
                            betting.Bet = 0;
                            break;
                        case "7":
                            hit = rules.DealerBustOrNot(dealer.dealerPoints);
                            break;
                        default:

                            break;
                    }
                }
            }
        }
    }

}
