using System;
using System.Collections.Generic;

namespace Module12._1
{
    class Program
    {

        static void Main(string[] args)
        {
        string[] rockstarsArray = new string[] { "Jim Morrison", "Ozzy Osborne", "Peter Gabriel", "Ayreon" };
        List<string> rockstarsList = new List<string> { "Jim Morrison", "Ozzy Osborne", "Peter Gabriel", "Ayreon" };

            DisplayArrayOfRockStars(rockstarsArray);
            DisplayListOfRockStars(rockstarsList);
            DisplayIenumerableOfRockstars(rockstarsList);
            DisplayIenumerableOfRockstars(rockstarsArray);


        }

        private static void DisplayIenumerableOfRockstars(IEnumerable<string> rockstars)
        {
            Header("My rockstars: (Ienumerable)");
            


            foreach (string name in rockstars)
            {
                Console.WriteLine("* " + name);
            }
            Console.WriteLine();
        }

        private static void DisplayArrayOfRockStars(string[] rockstars)
        {
            Header("My rockstars: (array)");

            foreach (string name in rockstars)
            {
                Console.WriteLine("* "+ name);
            }
            Console.WriteLine();
        }


        private static void DisplayListOfRockStars(List<string> rockstars)
        {
            Header("My rockstars: (list)");

            rockstars.Add("David Bowie");

            foreach (string name in rockstars)
            {
                Console.WriteLine("* " + name);
            }
            Console.WriteLine();

        }


        private static void Header(string v)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(v);
            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}
