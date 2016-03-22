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
            Betting betting = new Betting();
            Player player = new Player(100);
            Dealer dealer = new Dealer();
            Rules rules = new Rules();

            //NewDeck.Shuffle();

            Console.WriteLine("Press enter to start playing");
            Console.ReadLine();
            Console.Clear();
            betting.BetPlayer(betting._bet);
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

            //Console.ReadKey();

        }
    }
}
