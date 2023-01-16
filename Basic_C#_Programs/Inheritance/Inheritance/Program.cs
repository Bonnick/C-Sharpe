using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //card card = new card();
            //card.face = "king";
            //card.suit = "spades";

            //Easier way to do the above
            //Card card = new Card() { Face = "King", Suit = "Spades" };

            //Games game = new Games();
            //game.Dealer = "Jesse";
            //game.Name = "TwentyOne";

            //TwentyOne games = new TwentyOne();
            //games.Players = new List<string> { "Jesse", "Bill", "Joe" };
            //games.ListPlayers();
            //games.Play();
            //Console.ReadLine();


            //Games games = new Games();
            //games.Players = new List<string> { "Jesse", "Bill", "Joe" };
            //games.ListPlayers();
            //Console.ReadLine();

            Deck deck = new Deck();
            deck.shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + "of" + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
