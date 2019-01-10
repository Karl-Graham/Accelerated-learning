using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CardGame
{
    class PlayingCardDeck
    {
        public static List<PlayingCard> Deck = new List<PlayingCard>();

        public static List<PlayingCard> NewDeck()
        {
            for (var i = 0; i < 4; i++)
            {
                for (var j = 1; j < 14; j++)
                {
                    Deck.Add(new PlayingCard((CardSuit)i, (CardFace)j, (CardStatues)1));
                }
            }
            return Deck;
        }

        internal static void PutCardLast(List<PlayingCard> deck, PlayingCard x)
        {
            deck.Add(x);
        }

        internal static void Shuffle(List<PlayingCard> deck)
        {
            Random rnd = new Random();
            for (var i = 0; i < deck.Count; i++)
            {
                int j = rnd.Next(0, deck.Count - 1);
                var temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }
        }

        internal static PlayingCard TopCard(List<PlayingCard> deck)
        {
            PlayingCard top = deck[0];
            deck.RemoveAt(0);
            return top;
        }
    }
}
