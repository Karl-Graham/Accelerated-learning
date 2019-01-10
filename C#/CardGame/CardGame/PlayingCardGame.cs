using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    class PlayingCardGame
    {
        public PlayingCardGame()
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<PlayingCard> deck = PlayingCardDeck.NewDeck();
            PlayingCardDeck.Shuffle(deck);
            PlayingCard PlayerCard = PlayingCardDeck.TopCard(deck);
            PlayingCard ComputerCard = PlayingCardDeck.TopCard(deck);
            Console.Write("Your card: ");
            DisplayCard(PlayerCard);
            string guess = GuessIfCardIsHigherOrLower();
            bool win = CompareCards(PlayerCard, ComputerCard, guess);
            Console.Write("Computer card: ");
            DisplayCard(ComputerCard);
            if (win)
            {
                Console.WriteLine("You Win");
            }
            if (!win)
            {
                Console.WriteLine("You Loose");
            }
            

        }

        private bool CompareCards(PlayingCard playerCard, PlayingCard computerCard, string guess)
        {
            bool win = false;
            if (playerCard.Face > computerCard.Face || (playerCard.Face == computerCard.Face && playerCard.Suit < computerCard.Suit))
            {
                if (guess == "h")
                    win = true;
            }
            else
            {
                if (guess == "l")
                    win = true;
            }
            return win;
        }

        private string GuessIfCardIsHigherOrLower()
        {
            bool wrongChar = true;
            string guess = "";
            do
            {
                Console.Write("Do you think you're card is Higher ot Lower then Computer card? (H/L):");
                guess = Console.ReadLine().ToString().ToLower();
                Console.WriteLine();
                if (guess == "l" || guess == "h")
                {
                    wrongChar = false;
                }
                else
                    Console.WriteLine("You've entered wrong charachter");
            } while (wrongChar);

            return guess;

        }

        private void DisplayCard(PlayingCard card)
        {
            Console.WriteLine(card.Face.ToString() + " of " + card.Suit.ToString() + "\n");
        }
    }
}
