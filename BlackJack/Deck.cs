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

        public List<Card> DeckList = new List<Card>();
        public Deck()
        {
            
           // foreach (var card in deck)
            //{
            //    //foreach ()
            //    //{
            //    //    //List<string> faces = new List<string>();
            //    //    //List<string> suits = new List<string>();
            //    //}
            
            //}
           
            deck = new Card[numberOfCards];
            currentCard = 0;
            randomNumber = new Random();
            //for (int length = 0; length < deck.Length; length++)
            //    deck[length] = new Card(faces[length % 13], suits[length / 13]);
        }
        public void Shuffle()       //Shuffles the DeckList
        {
            int n = DeckList.Count;
            Random rnd = new Random();
            while (n > 1)
            {
                int k = (rnd.Next(0, n) % n);
                n--;
                Card value = DeckList[k];
                DeckList[k] = DeckList[n];
                DeckList[n] = value;
            }
        }
        public Card DealOneCard()   // Deals one card from the deck.
        {

            return deck[currentCard++];
        }
        public void CalculateHand()
        {
            var ValueInHand = "";
            //int Aces = 0;
            int Total = 0;
            //TODO Ändra till nine istället för 9, One istället för 1
            switch(ValueInHand)
            {
                case "Two":
                    Total += 2;
                    break;
                case "Three":
                    Total += 3;
                    break;
                case "Four":
                    Total += 4;
                    break;
                case "Five":
                    Total += 5;
                    break;
                case "Six":
                    Total += 6;
                    break;
                case "Seven":
                    Total += 7;
                    break;
                case "Eight":
                    Total += 8;
                    break;
                case "Nine":
                    Total += 9;
                    break;
                case "King":
                case "Queen":
                case "Jack":
                case "Ten":
                    Total += 10;
                    break;

                default:
                    throw new Exception("Didnt recognize your card");
                    

            }
            
        }
  

    }
}
