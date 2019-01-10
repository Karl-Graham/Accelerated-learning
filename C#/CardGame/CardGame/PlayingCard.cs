using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    class PlayingCard
    {
        public PlayingCard()
        {
        }

        internal PlayingCard(CardSuit suit, CardFace face, CardStatues statues)
        {
            this.Suit = suit;
            this.Face = face;
            this.Statues = statues;
        }

        public CardSuit Suit { get; set; }
        public CardFace Face { get; set; }
        public CardStatues Statues { get; set; }
    }
}
