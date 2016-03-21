using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    //Ser ok ut
    class Betting
    {
        Card Cardssen = new Card();
        Player player = new Player(100);
        Deck deck = new Deck();
        public int _bet { get; set;}

        public void BetPlayer (int _bet)
        {
            Console.WriteLine(@"What do you want to bet? 
5/10/20/50/100/500");
            switch (_bet)
            {
                
                case 5:
                    Console.WriteLine("Your bet is 5, if you win you will have " + player._balance + 5 + "Kr");
                    
                    break;
                case 10:

                    Console.WriteLine("Your bet is 10, if you win you will have " + player._balance + 10 + "Kr");
                    break;
                case 20:

                    Console.WriteLine("Your bet is 20, if you win you will have " + player._balance + 20 + "Kr");
                    break;
                case 50:

                    Console.WriteLine("Your bet is 50, if you win you will have " + player._balance + 50 + "Kr");
                    break;
                case 100:

                    Console.WriteLine("Your bet is 100, if you win you will have " + player._balance + 100 + "Kr");
                    break;
                case 500:

                    Console.WriteLine("Your bet is 500, if you win you will have " + player._balance + 100 + "Kr");
                    
                    break;
                default:
                    if (player._balance < _bet)
                        Console.WriteLine("You dont have that kind of money: ");
                    Console.WriteLine("You have: " + player._balance);
                    break;
            }
        }
    }
}
