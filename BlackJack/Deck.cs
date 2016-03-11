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
            foreach (var card in deck)
            {
                foreach ()
                {
                    List<string> faces = new List<string>();
                    List<string> suits = new List<string>();
                }
            
            }
           
            deck = new Card[numberOfCards];
            currentCard = 0;
            randomNumber = new Random();
            //for (int length = 0; length < deck.Length; length++)
            //    deck[length] = new Card(faces[length % 13], suits[length / 13]);
        }
        public void Shuffle()       //Shuffles the deck.
        {
            currentCard = 0;
            for (int first = 0; first < deck.Length; first++)
            {
                int second = randomNumber.Next(numberOfCards);
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }
        public Card DealOneCard()   // Deals one card from the deck.
        {

            return deck[currentCard++];
        }
        public void CalculateHand()
        {
            string ValueInHand = "";
            //int Aces = 0;
            int Total = 0;
            //TODO Ändra till nine istället för 9, One istället för 1
            switch(ValueInHand)
            {
                case "King":
                case "Queen":
                case "Jack":
                case "10":
                    Total += 10;
                         break;
                case
                    "9":
                    Total += 9;
                    break;
                case
                    "8":
                    Total += 8;
                    break;
                case
                    "7":
                    Total += 7;
                    break;
                case
                    "6":
                    Total += 6;
                    break;
                case
                    "5":
                    Total += 5;
                    break;
                case
                    "4":
                    Total += 4;
                    break;
                case
                    "3":
                    Total += 3;
                    break;
                case "2":
                    Total += 2;
                    break;

                default:
                    throw new Exception("Didnt recognize your card");
                    break;
                    



            }
        }


    }
}
