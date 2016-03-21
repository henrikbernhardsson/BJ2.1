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
        public void DealerHand(string dealerCard)
        {
            dealersCards.Add(dealerCard);
        }
        public int DealerPoints()
        {
            int result = 0;
            foreach (var item in dealersCards)
            {
                result += Deck.CalculateHand(item);
            }
            return result;
        }

    }
}
