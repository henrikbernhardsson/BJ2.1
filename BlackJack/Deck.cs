using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck 
    {
        Player player = new Player(100);
        private int currentCard = 0;
        public List<Card> DeckList = new List<Card>();
        public Deck()
        {
            var card1 = new Card();

            foreach (var item in card1.faces)
            {
                var hearts = new Card(item, card1.suits[0]);
                var clubs = new Card(item, card1.suits[1]);
                var spades = new Card(item, card1.suits[2]);
                var diamonds = new Card(item, card1.suits[3]);
                DeckList.Add(hearts);
                DeckList.Add(clubs);
                DeckList.Add(spades);
                DeckList.Add(diamonds);
            }
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
        public Card DealOneCard()   // Deals one card from the DeckList.
        {
            return DeckList[currentCard++];
        }
        public int CalculateHand(string _ValueInHand)
        {
            string ace = "";
            
            string ValueInHand = _ValueInHand;
            //int Aces = 0;
            int Total = 0;
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
                case "Ace":
                    player.Ace(Total);
                    
                    break;

                default:
                    throw new Exception("Didnt understand");
                    

            }
            return Total;

            
        }
        public int Ace(int Total)
        {
            int aceValue = 0;
            while (aceValue != 1 && aceValue != 11)
            {
                Console.WriteLine("Do you want the ace to count as 1 or 11? ");
                aceValue = int.Parse(Console.ReadLine());
                Total += aceValue;
            }
            return Total;
        }


    }
}
