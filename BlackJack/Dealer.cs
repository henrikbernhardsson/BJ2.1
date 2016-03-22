using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Dealer
    {
        List<string> dealersCards = new List<string>();
        int dealerPoints;
        int counter;
        public void DealerHand(string dealerCard)
        {
            dealersCards.Add(dealerCard);
        }
      
        public int DealerPoints()
        {


            dealerPoints += Deck.CalculateHand(dealersCards[counter]);
            counter++;
            return dealerPoints;
        }
        
    }
}
