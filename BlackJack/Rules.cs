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
        public void gaming ()
        {
            Card cardsses = new Card();
            if (cardsses.face == "21")
            {
                Console.WriteLine(cardsses);
            }

        }
    }
}
