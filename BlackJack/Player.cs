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
        List<Card> PlayersHand = new List<Card>();
        public int _balance { get; set; }

        public Player(int Balance)
        {
            this._balance = Balance;

            int inputbyPlayer = int.Parse(Console.ReadLine());

            Console.Write(@"How much do you want to put in as starting capital?: ");
            Console.Write("Your enterd: " + inputbyPlayer);
            Balance = inputbyPlayer;
        }
        
        
       
        //TODO KOLLA!! Ifall playershand är mindre än eller densamma som 21 
        public int PlayerHand()
        {
            int result = 0;
            foreach (var card in PlayersHand)
            {
                result += deck.CalculateHand(card.face);
            }
            return result;
        }

        //for (int i = 0; i < deck.DealOneCard.)
        //    foreach (var card in Cardlist)
        //    {
        //        currentCard++;
        //        foreach (var cardss in deck.DeckList)
        //        {

        //        }
        //    }
        //foreach (var card in decklist)
        //{
        //    deck.DeckList.Add(cardssen.)
        //}
        //Console.WriteLine("Here is your first card ");
        // if satser för att göra så att playerns totala värde ökar för varje kort,
        // den samma för dealern, korten ska också öka i antal.
    }
}
}
  