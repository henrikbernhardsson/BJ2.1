using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
 
    class Rules
    {
        //Checkar ifall playern är över 21.
        public string PlayerBustOrNot(int points)
        {

            if (points > 21)
            {
                Console.WriteLine("You'r busted.");
                return "5";
            }

            return "1";
        }
        
        //Checkar ifall dealern är över 21.
        public string DealerBustOrNot(int points)
        {
            if (points > 21)
            {
                Console.WriteLine("DEALER's busted.");
                return "4";
            }
            
            return "3";
        }
        // Om dealerns värde är totalt 17 ska den stanna.
        public string dealerstays(int points) 
        {
            if (points >= 17)
            {
                Console.WriteLine("DEALER stays");
                return "7";
            }
            return "2";
        }
        //Jämför spelarnas poäng och utser en vinnare.
        public string Winner(int playerPoints, int dealerPoints, List<string> playerHand)
        {
            if (playerPoints > dealerPoints)
            {
                Console.WriteLine("PLAYER wins");
                return "4";

            }
            if (dealerPoints > playerPoints)
            {
                Console.WriteLine("DEALER wins");
                return "5";
            }
            if (dealerPoints == playerPoints)
            {
                if (playerHand.Count < 5)
                {
                    Console.WriteLine("PLAYER Wins");
                    return "4";
                }
                Console.WriteLine("DEALER wins");
                return "5";
            }
            return "6";

        }
    }
}