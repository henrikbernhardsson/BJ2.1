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
        List<Card> playersHand = new List<Card>();
        public int _balance { get; set; }

        //public List<Card> PlayersHand
        //{
        //    get
        //    {
        //        return playersHand;
        //    }

        //    set
        //    {
        //        playersHand = value;
        //    }
        //}

        public Player(int Balance)
        {
            this._balance = Balance;
        }
          //TODO KOLLA!! Ifall playershand är mindre än eller densamma som 21 
        public int PlayerHand()
        {
            int result = 0;
            foreach (var card in playersHand)
            {
                result += deck.CalculateHand(card.face);
            }
            return result;
        }


    }
}

  