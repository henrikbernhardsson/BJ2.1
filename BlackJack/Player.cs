using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Player
    {
        Deck deck = new Deck();
        Card cardssen = new Card();
        List<string> playersCards = new List<string>();
        public int _balance { get; set; }

        public void PlayersHand(string playerCard)
        {
            playersCards.Add(playerCard);
        }

        public Player(int Balance)
        {
            this._balance = Balance;
        }
          //TODO KOLLA!! Ifall playershand är mindre än eller densamma som 21 
        public int PlayerPoints()
        {
            int result = 0;
            foreach (var item in playersCards)
            {
                result += Deck.CalculateHand(item);
            }
            return result;
        }


    }
}

  