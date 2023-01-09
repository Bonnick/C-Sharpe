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

          deck = Shuffle(deck);
            
           

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
        //Add a Method
        public static Deck Shuffle(Deck deck)
        {
            List<Card> TempList = new List<Card>();
            Random rondom = new Random();

            while (deck.Cards.Count > 0)
            {
                int random index = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }
            deck.Cards = TempList;
            return deck;

        }
    }
}
