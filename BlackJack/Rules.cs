using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    //1. The one closest but not over 21 wins the round. 
    //2. Over 21, are fat and loose the game. 
    //3. If the dealer has 17 he dont take more cards.
    //5. Face cards(i.e.Knights, Queens and Kings) have the value of 10. 
    //6. Ace has either value of 1 or 11 
    //7. Most have two cards. 

    //8. Least 2 cards to every player + dealer
    // cw (one more card? y/n)
    class Rules
    {
        public string PlayerFatOrNot(int points)
        {

            if (points > 21)
            {
                Console.WriteLine("You'r fat.");
                return "5";
            }

            return "1";
        }

        public string DealerFatOrNot(int points)
        {
            if (points > 21)
            {
                Console.WriteLine("Dealer's fat.");
                return "4";
            }
            
            return "3";
        }
        public string dealerstays(int points) // Om dealerns värde är totalt 17 ska den stanna
        {
            if (points >= 17)
            {
                Console.WriteLine("Dealer stays");
                return "7";
            }
            return "2";
        }
        public string Winner(int playerPoints, int dealerPoints)
        {
            if (playerPoints > dealerPoints)
            {
                Console.WriteLine("Player wins");
                return "4";

            }
            if (dealerPoints > playerPoints)
            {
                Console.WriteLine("Dealer wins");
                return "5";
            }
            if (dealerPoints == playerPoints)
            {
                Console.WriteLine("Dealer wins");
                return "5";
            }
            return "6";

        }
    }
}