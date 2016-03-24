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
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Here is your first card");
                var PlayerCard = NewDeck.DealOneCard();
                player.PlayersHand(PlayerCard.face);
                Console.WriteLine($"PLAYER: {PlayerCard}and your currently at: {player.PlayerPoints()}\n");
                Thread.Sleep(1200);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Dealer gets a card");
                var DealerCard = NewDeck.DealOneCard();
                dealer.DealerHand(DealerCard.face);
                Console.WriteLine($"DEALER: {DealerCard}and is currently at: {dealer.DealerPoints()}\n");
                Thread.Sleep(1200);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Here is your second card");
                PlayerCard = NewDeck.DealOneCard();
                player.PlayersHand(PlayerCard.face);
                Console.WriteLine($"PLAYER: {PlayerCard}and your currently at: {player.PlayerPoints()}\n");
                hit = rules.PlayerBustOrNot(player.points);
                DealerCard = NewDeck.DealOneCard();
                
                while (run)
                {

                    switch (hit)
                    {
                        case "1":
                            Console.WriteLine("Another card?\n1.Yes\n2.No");
                            hit = Console.ReadLine();
                            while (hit != "1" && hit != "2")
                            {
                                Console.WriteLine("Enter a valid option");
                                hit = Console.ReadLine();
                            }
                            if (hit == "2")
                            {
                                break;
                            }
                            PlayerCard = NewDeck.DealOneCard();
                            player.PlayersHand(PlayerCard.face);
                            Console.WriteLine($"PLAYER: {PlayerCard}and your currently at: {player.PlayerPoints()}\n");
                            hit = rules.PlayerBustOrNot(player.points);

                            break;
                        case "2":
                            Console.ForegroundColor = ConsoleColor.Red;
                            dealer.DealerHand(DealerCard.face);
                            Console.WriteLine($"DEALER: {DealerCard}and is currently at: {dealer.DealerPoints()}\n");
                            hit = rules.dealerstays(dealer.dealerPoints);
                            while (hit == "2")
                            {
                                
                                DealerCard = NewDeck.DealOneCard();
                                dealer.DealerHand(DealerCard.face);
                                Console.WriteLine($"DEALER: {DealerCard}and is currently at: {dealer.DealerPoints()}\n");
                                hit = rules.dealerstays(dealer.dealerPoints);
                            }
                            break;

                        case "3":
                            hit = rules.Winner(player.points, dealer.dealerPoints);
                            break;
                        case "4":
                            Console.ForegroundColor = ConsoleColor.Green;
                            player._balance = (betting.Bet + player._balance);
                            Console.WriteLine("Your balance is now: " + player._balance);
                            hit = "6";
                            break;
                        case "5":
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            player._balance = (player._balance - betting.Bet);
                            Console.WriteLine("Your balance is now: " + player._balance);
                            hit = "6";
                            break;

                        case "6":
                            if (player._balance < 1)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine(Ascii(1)); 
                                Thread.Sleep(3000);
                                keepPlaying = false;
                                run = false;
                                break;
                            }
                            Console.WriteLine("Do you want to play again?\n1.Yes\n2.No");
                            string again = Console.ReadLine();
                            while (again != "1" && again != "2")
                            {
                                Console.WriteLine("You entered a non valid option, Press 1 to play again or 2 to exit the game");
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
                            Console.Clear();
                           
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
        public string Ascii(int ascii)
        {
            if (ascii == 1)
            {
                return @"┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼
███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀
██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼
██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀
██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼
███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄
┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼
███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼
██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼
██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼
██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼
███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄
┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼
┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼
┼┼┼┼┼┼████▄┼┼┼▄▄▄▄▄▄▄┼┼┼▄████┼┼┼┼┼┼┼
┼┼┼┼┼┼┼┼┼▀▀█▄█████████▄█▀▀┼┼┼┼┼┼┼┼┼┼
┼┼┼┼┼┼┼┼┼┼┼█████████████┼┼┼┼┼┼┼┼┼┼┼┼
┼┼┼┼┼┼┼┼┼┼┼██▀▀▀███▀▀▀██┼┼┼┼┼┼┼┼┼┼┼┼
┼┼┼┼┼┼┼┼┼┼┼██┼┼┼███┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼
┼┼┼┼┼┼┼┼┼┼┼█████▀▄▀█████┼┼┼┼┼┼┼┼┼┼┼┼
┼┼┼┼┼┼┼┼┼┼┼┼███████████┼┼┼┼┼┼┼┼┼┼┼┼┼
┼┼┼┼┼┼┼┼▄▄▄██┼┼█▀█▀█┼┼██▄▄▄┼┼┼┼┼┼┼┼┼
┼┼┼┼┼┼┼┼▀▀██┼┼┼┼┼┼┼┼┼┼┼██▀▀┼┼┼┼┼┼┼┼┼
┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼
┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼";
            }
            if (ascii == 2)
            {
                return @"          _________________________________________________________
         |                                                         |
         |                        Welcome to                       |
         |       ____  _            _     _            _           |
         |      | __ )| | __ _  ___| | __(_) __ _  ___| | __       |
         |      |  _ \| |/ _` |/ __| |/ /| |/ _` |/ __| |/ /       |
         |      | |_) | | (_| | (__|   < | | (_| | (__|   <        |
         |      |____/|_|\__,_|\___|_|\_\/ |\__,_|\___|_|\_\       |
         |                             |__/                        |
         |_________________________________________________________|
";
            }
            return null;
        }

    }

}
