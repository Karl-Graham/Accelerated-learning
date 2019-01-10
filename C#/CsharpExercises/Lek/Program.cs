using System;
using System.Linq;

namespace Lek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = EnterWords();
            string framedWords = Frame(words);
            Console.WriteLine(framedWords);
        }

        private static string[] EnterWords()
        {
            Console.Write("Enter words you want to be framed. Seperate each word with ',':");
            string word = Console.ReadLine();
            string[] words = word.Split(',');
            return words;
        }

        public static string Frame(string[] v)
        {
            if (v == null)
                throw new ArgumentException();

            string s = "";

            if (v.Length > 0)
            {
                int i = v.Max(x => x.Length);

                s += "╔" + new string('═', i + 2) + "╗";

                foreach (var item in v)
                    s += "\n║ " + item + new string(' ', i - item.Length) + " ║";

                s += "\n╚" + new string('═', i + 2) + "╝";
            }

            return s;
        }
    }
}
