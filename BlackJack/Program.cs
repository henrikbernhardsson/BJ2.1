﻿using System;
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
            Betting betting = new Betting();
            Player player = new Player(100);

            NewDeck.Shuffle();

            Console.WriteLine("Press enter to start playing");
            Console.Clear();
            Console.WriteLine("Here is your first card from the dealer");
            var PlayerCard = NewDeck.DealOneCard();
            Console.WriteLine(PlayerCard);
            Console.WriteLine("Dealer gets a card");
            var DealerCard = NewDeck.DealOneCard();
            Console.WriteLine(DealerCard);
            betting.BetPlayer(betting._bet);
            
            //NewDeck.CalculateHand(PlayerCard.face);
            //Console.WriteLine("Press enter to print the entire Deck of Cards..");
            //Console.ReadKey();
            //foreach (var item in NewDeck.DeckList)
            //{
            //    Console.Write(item);
            //}

            //Console.ReadKey();

        }
    }
}
