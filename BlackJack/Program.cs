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
          
                 


            Game game = new Game();
            Console.WriteLine(game.Ascii(2));         //Prints Ascii picture
            Thread.Sleep(2500);
            var NewDeck1 = new Deck();

            Player player1 = new Player(100);
            Dealer dealer1 = new Dealer();
            Betting betting1 = new Betting();
            Rules rules1 = new Rules();
            game.RunGame(NewDeck1, player1, dealer1, betting1, rules1);
            Console.WriteLine("Press any key to exit the game");
            Console.ReadKey();
            


            




        }
    }
}
