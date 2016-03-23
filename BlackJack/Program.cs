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
        

        static void Main(string[] args)
        {
            //TODO: player1.balance = 0, GameOver
            //      dealers hidden card.
            //      


            Game game = new Game();
            
            var NewDeck1 = new Deck();

            Player player1 = new Player(100);
            Dealer dealer1 = new Dealer();
            Betting betting1 = new Betting();
            Rules rules1 = new Rules();
            game.RunGame(NewDeck1, player1, dealer1, betting1, rules1);

            


            




        }
    }
}
