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
        //Lägger till kort i dealerns lista av kort.
        public void DealerHand(string dealerCard)
        {
            dealersCards.Add(dealerCard);
        }
        //Räknar ut Dealerns poäng för tillfället.
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
        //Om dealern får ess väljer han själv värde beroende på hans tillfälliga poäng.
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

