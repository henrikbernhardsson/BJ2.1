using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Player
    {
        
        
        public List<string> playersCards = new List<string>();
        public int points = 0;
        int counter = 0;
        public int _balance { get; set; }

        //Lägger till spelarens kort i en egen lista.
        public void PlayersHand(string playerCard)
        {
            playersCards.Add(playerCard);
        }

        public Player(int Balance)
        {
            this._balance = Balance;
        }
        
        //Räknar ut spelarens poäng för tillfället.
        public int PlayerPoints()
        {


            points += Deck.CalculateHand(playersCards[counter]);
            counter++;
            return points;
        }


    }
}

