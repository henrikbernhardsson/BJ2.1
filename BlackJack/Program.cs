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
            int run = 0;
            Deck deck1 = new Deck();
            deck1.Shuffle();

            Console.WriteLine("---♥-♠-♦-♣--Welome-To-Blackjack--♥-♠-♦-♣---");

            while (run <= 51)
            {
                Console.WriteLine(deck1.DealOneCard());
                run++;
            }



            //Testing the logic: Deals one random card.
            //for (int i = 0; i < 52; i++)
            //{
            //    Console.Write("{0,-19}", deck1.DealOneCard());
            //    if ((i + 1) % 4 == 0)
            //    {
            //        Console.WriteLine();
            //    }
            //}

            Console.ReadKey();




            //Player player = new Player(100);
            //string choice = Console.ReadLine();
            //var result = true;
            //// Meny to now if bets are being made, or a card is wanted
            ////loooooooooooooo
            ////lloooookok
            //while (result)
            //{
            //    switch (choice)
            //    {
            //        case "1":
            //            Console.WriteLine("");
            //            break;
            //        case "2":
            //            Console.WriteLine("");
            //            break;
            //        case "3":
            //            Console.WriteLine("");
            //            break;
            //    }
            //    result = false;
            //}
        }
    }
}
