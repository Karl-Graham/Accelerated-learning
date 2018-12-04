using System;
using System.Text.RegularExpressions;

namespace Module8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ok = false;

            do
            {

                string animalsString = AskForAnimals();

                try
                {
                    string[] animalArray = ParseAnimals(animalsString);
                    int numberOfAnimals = animalArray.Length;

                    Console.WriteLine($"There are {numberOfAnimals} animals in the list");
                    ok = true;
                }
                catch (ArgumentException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.Gray;

                }
            } while (ok == false);

        }

        private static string[] ParseAnimals(string animalsString)
        {
            string[] animalArray = animalsString.Split(',');


            if (animalArray.Length == 1 && animalArray[0] == "")
                throw new ArgumentException("Animal string don't contain any letters");




            foreach (var item in animalArray)
            {
                string animal = item.Trim();
                foreach (char letter in animal)
                {
                    if (!Char.IsLetter(letter))

                        throw new ArgumentException($"Animal '{animal}' contains invalid letters");
                }

                if (animal == "")
                    throw new ArgumentException("One of the animals didn't contain any letters");


                if (animal.Length > 19)
                    throw new ArgumentException($"This animal '{animal}' has too many letters");

            }
            return animalArray;
        }

        private static string AskForAnimals()
        {
            Console.Write("Enter a list of animals: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string animals = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            return animals;
        }
    }
}
