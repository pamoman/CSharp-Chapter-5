using System;

namespace CSharp_Chapter_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] deck = new string[52];

            string[] suits = { "Hearts", "Diamonds", "Spades", "Clubs" };

            int deckIndex = 0;
            int deckLength = deck.Length;
            int suitsLength = suits.Length;

            for (int suit = 0; suit < suits.Length; suit++)
            {

                for (int card = 0; card < (deckLength / suitsLength); card++)
                {
                    deck[deckIndex] = $"{card + 1} of {suits[suit]}";

                    deckIndex++;
                }
            }

            bool found = false;
            string find = "2 of Hearts";

            foreach (string card in deck)
            {
                if (card == find)
                {
                    found = true;
                }

                Console.WriteLine(card);
            }

            string result = found ? "found" : "not found";

            Console.WriteLine($"\nThe card {find} was {result}");
        }
    }
}
