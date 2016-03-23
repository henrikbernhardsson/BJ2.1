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
        public int dealerPoints;
        int counter;
        public void DealerHand(string dealerCard)
        {
            dealersCards.Add(dealerCard);
        }

        public int DealerPoints()
        {

            if (dealersCards[counter] == "Ace")
            {
                dealerPoints += DealerGetsAce(dealerPoints);
            }
            else
            {
                dealerPoints += Deck.CalculateHand(dealersCards[counter]);
            }
            
            counter++;
            return dealerPoints;
        }
        public int DealerGetsAce(int handvalue)
        {
            int value = 11;
            if (handvalue >= 11)
            {
                value = 1;
            }
            return value;
        }


    }
}

