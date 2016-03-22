using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Card
    {
        public string face;
        public string suit;
        public List<string> faces = new List<string>();
        public List<string> suits = new List<string>();

        public Card()
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

            suits.Add("Hearts");
            suits.Add("Clubs");
            suits.Add("Spades");
            suits.Add("Diamonds");
        }
        public Card(string cardFace, string cardSuit)
        {
            face = cardFace;
            suit = cardSuit;
        }
        public override string ToString()
        {
            return $"{face} of {suit} ";
        }

    }
}

