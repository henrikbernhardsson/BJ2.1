using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        // TODO GÖR KLASS DIAGRAM
        //TODO Game ska hålla reda på vem som vinner , värdet på handen etc

        static void Main(string[] args)
        {
            Player player = new Player(100);
            string choice = Console.ReadLine();
            var result = true;
            // Meny to now if bets are being made, or a card is wanted
            //loooooooooooooo
            //lloooookok
            while (result)
            {
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("");
                        break;
                    case "2":
                        Console.WriteLine("");
                        break;
                    case "3":
                        Console.WriteLine("");
                        break;
                }
                result = false;
            }
        }
    }
}
