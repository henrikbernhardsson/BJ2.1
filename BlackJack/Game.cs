using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    //Motor
    class Game
    {
        Player player = new Player(100);
        Dealer dealer = new Dealer();
        Betting betting = new Betting();
        public bool Win { get; set; }
        public bool Lose { get; set; }
        public bool HighCard { get; set; }

        public void WinnerLoser()
        {
            if (Win == true)
            {
                //öka värdet ifall man vinner
                player._balance = betting._bet + player._balance;
                Console.WriteLine("Du vann, du har nu: " + player._balance);
            }
            else
            {
                // minska beloppet man hade ifall man förlorat
                player._balance = betting._bet - player._balance;
                Console.WriteLine("Du har tyvärr förlorat, du har nu: " + player._balance);
            }
            //Skapa variabler/logik i både playerhand och dealerhand 
            //så att man kan se vem som ska vinner, förlorar osv
            //
            // if (player.PlayerHand > dealer.DealerHand || player.PlayerHand == 21)
            //försök 4
            {

            }

        }
    }
}
