using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    enum CardSuit
    {
        Spades = 0,
        Hearts = 1,
        Diamonds = 2,
        Clubs = 3
    }//{ ♠, ♥, ♦, ♣}

    enum CardFace
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }

    enum CardStatues
    {
        Open = 0,
        Closed = 1 
    }
}
