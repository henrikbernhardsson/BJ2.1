using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    //Ser ok ut
    class Betting
    {
        Player player = new Player(100); 
        public int _bet { get; set;}

        public void BetPlayer (int _bet)
        {
           
            Console.WriteLine(@"What do you want to bet, between 1-10. Your current balance is: " + player._balance);
            _bet = int.Parse(Console.ReadLine());
            while (_bet > 10 || _bet < 1 || _bet > player._balance)
            {
                Console.WriteLine(@"Your bet is over/under the bet-limit or your balance is not big enough. 
Your balance is: " + player._balance);
                Console.WriteLine("Enter a bet between 1 - 10: ");
                _bet = int.Parse(Console.ReadLine());
               
            }
        }
    }
}
