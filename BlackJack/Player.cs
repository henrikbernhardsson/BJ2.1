using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Player
    {
        
        private int _balance { get; set; }
        public Player(int balance)
        {
            _balance = _balance;
        }
        public void game()
        {

        }
        public int Ace(int Total)
        {
            int aceValue = 0;
            while (aceValue != 1 && aceValue != 11)
            {
                Console.WriteLine("Do you want the ace to count as 1 or 11? ");
                aceValue = int.Parse(Console.ReadLine());
                Total += aceValue;
            }
            return Total;
        }
        public void PlayerHand()
        {
            //Console.WriteLine("Here is your first card ");
            // if satser för att göra så att playerns totala värde ökar för varje kort,
            // den samma för dealern, korten ska också öka i antal.
        }
    }
}
