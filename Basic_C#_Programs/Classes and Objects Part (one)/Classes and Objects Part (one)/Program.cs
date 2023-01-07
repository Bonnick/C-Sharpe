using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects_Part__one_
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            //deck.Cards = new List<Card>();



            //Card cardOne = new Card();
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";

            //deck.Cards.Add(cardOne);

            foreach ( Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);

            //Console.WriteLine(deck.Cards[01].Face  + " of " + deck.Cards[0].Suit);
            Console.ReadLine();
        }
    }
}
