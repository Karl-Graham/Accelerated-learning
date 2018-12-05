using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Module10
{
    class Program
    {
        static void Main(string[] args)
        {
            //ManipulateAList10_4();
            //ManipulateAList10_4Extra1();
            ProductListWithDictionary10_5();
        }

        private static void ProductListWithDictionary10_5()
        {
            var listan = new Dictionary<int, string>();
            bool v = true;
            bool replace = AskUserIfItWantsToReplaceId();

            do
            {

                string entry = AskUserForNewEntry();

                if (string.IsNullOrWhiteSpace(entry))
                    v = false;

                else
                {
                    try
                    {
                        listan = AddEntryToList(entry, listan, replace);

                    }
                    catch (Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }

            } while (v == true);

            PrintDictionary(listan);
        }

        private static bool AskUserIfItWantsToReplaceId()
        {
            bool replace = false;
            Console.Write("Do you want to replace an id if it already exist (y/n): ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string c = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            if (c == "y")
                replace = true;

            return replace;


        }

        private static void PrintDictionary(Dictionary<int, string> listan)
        {
            foreach (var item in listan)
            {
                Console.WriteLine($"Product id={item.Key} and name={item.Value}");
            }
        }

        private static Dictionary<int, string> AddEntryToList(string entry, Dictionary<int, string> listan, bool replace)
        {
            string[] command = entry.Split(":");
            string[] entryArray = command[0].Split(",");

            if (command.Length > 1)
            {
                bool replaceBool = Regex.IsMatch(command[1], "replace", RegexOptions.IgnoreCase);
                bool toUpperBool = Regex.IsMatch(command[1], "toupper", RegexOptions.IgnoreCase);

                if (replaceBool)
                {
                    replace = true;
                }
                if (toUpperBool)
                {
                    entryArray[1] = entryArray[1].ToUpper();
                }
            }

            if (listan.ContainsKey(int.Parse(entryArray[0])))
            {
                if (replace == true)
                {
                    listan[int.Parse(entryArray[0])] = entryArray[1];
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"The product list already contains the id {int.Parse(entryArray[0])}");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            else
            {
                listan.Add(int.Parse(entryArray[0]), entryArray[1]);
            }
            return (listan);

        }

        private static string AskUserForNewEntry()
        {
            Console.Write("Enter product id and name: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string entry = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            return entry;
        }

        //private static void ManipulateAList10_4Extra1()
        //{
        //    List<int> numbers = AskUserForNumbers();
        //    decimal mean = CalculateMean(numbers);
        //}

        //private static decimal CalculateMean(List<int> numbers)
        //{
        //    decimal total = 0;
        //    foreach (int n in numbers)
        //    {
        //        total = +n;
        //    }

        //    int numbersOfEntrys = numbers.Count();
        //    decimal mean = total / numbers.Count();


        //}

        private static List<int> AskUserForNumbers()
        {
            List<int> numbers = new List<int>();
            bool exit = false;
            do
            {
                Console.Write("Enter a number: ");

                Console.ForegroundColor = ConsoleColor.Green;
                string number = Console.ReadLine();
                number = number.Trim();
                string endMessage = number.ToUpper();
                Console.ForegroundColor = ConsoleColor.Gray;



                if (endMessage == "QUIT")
                    exit = true;

                else
                {
                    int numb = int.Parse(number);
                    numbers.Add(numb);
                }



            } while (exit == false);
            return numbers;
        }

        private static void ManipulateAList10_4()
        {
            List<string> names = AskUserforName();
            List<string> sortedList = SortList(names);
            DisplaySortedList(sortedList);

            Console.WriteLine();
        }

        private static void DisplaySortedList(List<string> sortedList)
        {
            foreach (var name in sortedList)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"Name: {name}");
                Console.ForegroundColor = ConsoleColor.Gray;

            }
        }

        private static List<string> SortList(List<string> names)
        {
            names.Sort();
            int listLenght = names.Count;
            if (listLenght > 1)
            {
                names.RemoveAt(listLenght - 1);
                names.RemoveAt(0);

            }
            return names;

        }

        private static List<string> AskUserforName()
        {
            List<string> names = new List<string>();
            bool exit = false;
            do
            {
                Console.Write("Enter a name: ");

                Console.ForegroundColor = ConsoleColor.Green;
                string name = Console.ReadLine();
                name = name.Trim();
                string endMessage = name.ToUpper();
                Console.ForegroundColor = ConsoleColor.Gray;



                if (endMessage == "QUIT")
                    exit = true;

                else
                    names.Add(name);



            } while (exit == false);
            return names;
        }
    }
}
