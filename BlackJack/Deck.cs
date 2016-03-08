using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck // metod cards in deck
    {
        //List<Card> deck = new List<Card>();

        private Card[] deck;
        private int currentCard;
        private const int numberOfCards = 52;
        private Random randomNumber;

      
        public Deck()
        {
            string[] faces = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] suits = { "♥", "♠", "♦", "♣" };

            deck = new Card[numberOfCards];
            currentCard = 0;
            randomNumber = new Random();
            for (int count = 0; count < deck.Length; count++)
                deck[count] = new Card(faces[count / 11], suits [count / 13]);

        }
    }
}
