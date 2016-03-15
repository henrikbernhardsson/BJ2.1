using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        //TODO Game ska hålla reda på vem som vinner , värdet på handen etc

        static void Main(string[] args)
        {
            var NewDeck = new Deck();

            NewDeck.Shuffle();

            Console.WriteLine("Press enter to deal one card from the shuffled deck..");
            Console.ReadKey();
            Console.WriteLine("You have been dealt: " + NewDeck.DealOneCard());
            
            Console.WriteLine("Press enter to print the entire Deck of Cards..");
            Console.ReadKey();
            foreach (var item in NewDeck.DeckList)
            {
                Console.Write(item);
            }

            Console.ReadKey();

        }
    }
}
