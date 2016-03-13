using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Card
    {
        private string face;
        private string suit;
        List<string> faces = new List<string>();
        List<string> suits = new List<string>();

        public Card(string cardFace, string cardSuit)
        {
            face = cardFace;
            suit = cardSuit;
        }
        public override string ToString()
        {
            return face + " of " + suit;
        }
        public void BuildLists()
        {
            faces.Add("Ace");
            faces.Add("Two");
            faces.Add("Three");
            faces.Add("Four");
            faces.Add("Five");
            faces.Add("Six");
            faces.Add("Seven");
            faces.Add("Eight");
            faces.Add("Nine");
            faces.Add("Ten");
            faces.Add("Jack");
            faces.Add("Queen");
            faces.Add("King");

            suits.Add("Heart");
            suits.Add("Clubs");
            suits.Add("Spades");
            suits.Add("Diamonds");
        }
        public void build()
        {
            foreach (var item in faces)
            {
                //var cards = new Card(item, suits[0]);
                Console.WriteLine(item + suits[0]);

            }
        }



    }
}


