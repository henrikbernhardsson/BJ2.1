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
        public int points = 0;
        int counter = 0;
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


            points += Deck.CalculateHand(playersCards[counter]);
            counter++;
            return points;
        }


    }
}

