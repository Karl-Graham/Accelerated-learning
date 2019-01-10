using System;
using System.Collections.Generic;


namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            NewGame();
        }

        private static void NewGame()
        {
            PlayingCardGame game = new PlayingCardGame();
        }
    }
}
