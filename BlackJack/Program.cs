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
            foreach (var item in NewDeck.DeckList)
            {
                Console.Write(item);
            }

            Console.ReadKey();

        }
    }
}
