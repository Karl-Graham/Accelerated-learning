using System;
using System.IO;

namespace Module9
{
    class Program
    {
        static void Main(string[] args)
        {
            WatchAFolder();
        }

        private static void WatchAFolder()
        {

            var watcher = new FileSystemWatcher();
            watcher.Path = @"C:\TMP";
            Console.WriteLine($"I'm watching this folder: {watcher.Path}");
            watcher.EnableRaisingEvents = true;

            var watcherOnsdag = new FileSystemWatcher();
            watcherOnsdag.Path = @"C:\TMP\onsdag.txt";
            watcherOnsdag.EnableRaisingEvents = true;


            watcher.Created += FileCreated;
            watcher.Deleted += FileDeleted;
            watcher.Changed += FileChanged;
            watcherOnsdag.Changed += OnsdagChanged;


            Console.ReadKey();


        }

        private static void OnsdagChanged(object sender, FileSystemEventArgs e)
        {
            
        }

        private static void FileChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine(e.Name + " ändrades");
            
        }

        private static void FileDeleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine(e.Name + " togs bort");
        }

        private static void FileCreated(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine(e.Name + " skapades!");
        }
    }
}
