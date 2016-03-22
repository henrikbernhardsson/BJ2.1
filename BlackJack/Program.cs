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
            betting.BetPlayer(betting._bets, player._balance);
            Console.Clear();
            Console.WriteLine("Here is your first card from the dealer");
            var PlayerCard = NewDeck.DealOneCard();
            player.PlayersHand(PlayerCard.face);
            Console.WriteLine($"You've got {PlayerCard}and your currently at: {player.PlayerPoints()}\n");
            Thread.Sleep(1500);

            Console.WriteLine("Dealer gets a card");
            var DealerCard = NewDeck.DealOneCard();
            dealer.DealerHand(DealerCard.face);
            Console.WriteLine($"Dealer got {DealerCard}and is currently at: {dealer.DealerPoints()}\n");
            Thread.Sleep(1500);

            Console.WriteLine("Here is your second card from the dealer");
            PlayerCard = NewDeck.DealOneCard();
            player.PlayersHand(PlayerCard.face);
            Console.WriteLine($"You've got {PlayerCard}and your currently at: {player.PlayerPoints()}\n");
            string Hit = "1";
            while (Hit == "1")
            {
                Console.WriteLine("another card?\n1.Yes\n2.No");
                Hit = Console.ReadLine();
                switch (Hit)
                {
                    case "1":
                        PlayerCard = NewDeck.DealOneCard();
                        player.PlayersHand(PlayerCard.face);
                        Console.WriteLine($"You've got {PlayerCard}and your currently at: {player.PlayerPoints()}\n");
                        Hit = (rules.FatOrNot(player.points));

                        break;
                    case "2":
                        Hit = "2";

                        Hit = (rules.dealerstays(player.points));
                        break;

                    case "3":
                        Hit = rules.Winner(player.points, dealer.dealerPoints);
                        break;
                    case "4":
                        player._balance = betting._bets + player._balance;
                        Console.WriteLine(player._balance);
                        break;
                    case "5":


                        break;

                    case "6":

                        break;

                    default:
                        Hit = "2";
                        break;
                }
            }


            Console.ReadLine();



            //NewDeck.CalculateHand(PlayerCard.face);
            //Console.WriteLine("Press enter to print the entire Deck of Cards..");
            //Console.ReadKey();
            //foreach (var item in NewDeck.DeckList)
            //{
            //    Console.Write(item);
            //}

            //Console.ReadKey(); ......

        }
    }
}
