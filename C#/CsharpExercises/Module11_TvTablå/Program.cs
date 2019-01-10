using System;
using System.Collections.Generic;
using System.Linq;

namespace Module11_TvTablå
{
    class Program
    {
        

        static void Main(string[] args)
        {
            List<Show> allShows = GetShowsFromTextFile();

            DisplayInfoAboutShows(allShows);

            Console.ReadKey();
        }


        private static List<Show> GetShowsFromTextFile()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\TMP\tv_data.txt");

            List<Show> allshows = new List<Show>();
                
            foreach (var item in lines)
            {
                string [] showString =item.Split('*');
                Show x = new Show();
                x.Channel = Enum.Parse<Channel>(showString[0]);
                x.ShowName = showString[2];                
                x.Time = TimeSpan.Parse(showString[1]);

                allshows.Add(x);
            }

            return allshows;
        }


        private static void DisplayInfoAboutShows(List<Show> allShows)
        {
            Console.WriteLine("ALLA TITLAR\n");

            allShows.ForEach(s => Console.WriteLine(s.ShowName));



            
            
        }
    }
}
