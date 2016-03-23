using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        //TODO Game ska hålla reda på vem som vinner , värdet på handen etc

        static void Main(string[] args)
        {
            var NewDeck = new Deck();

            Player player = new Player(100);
            Dealer dealer = new Dealer();
            Betting betting = new Betting();
            Rules rules = new Rules();

            NewDeck.Shuffle();

            Console.WriteLine("Press enter to start playing");
            Console.ReadLine();
            Console.Clear();
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
            string run = "1";
            string hit = "1";
            while (run == "1")
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
                        hit = rules.PlayerFatOrNot(player.points);

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
                        Console.WriteLine("Do you want to play again?");
                        run = "2";
                        break;
                    case "7":
                        hit = rules.DealerFatOrNot(dealer.dealerPoints);
                        break;
                    default:
                        
                        break;
                }
            }


            Console.ReadLine();




        }
    }
}
