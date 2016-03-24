using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    
    class Betting
    {

        public int Bet { get; set; }

        //Tar emot ett Bet.
        public void BetPlayer(int _bet, int playerBalance)
        {

            Console.WriteLine(@"What do you want to bet, between 1-10. Your current balance is: " + "("+ playerBalance+ ")");


            //Checkar så man sätter rätt value.
            try
            {
                _bet = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {

            
            }


            while (_bet > 10 || _bet < 1 || _bet > playerBalance)
            {
                
                Console.WriteLine(@"Wrong value ! Enter a valid bet. 
Your balance is: " + "(" + playerBalance + ")");
                Console.WriteLine("Enter a bet between 1 - 10: ");
                _bet = int.Parse(Console.ReadLine());
            }

            Bet = _bet;
        }
    }
}