using System;
using System.IO;

namespace Module8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool noException = false;
            string filename = "";

            do
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Gray;

                    Console.Write("Enter a file name: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    filename = Console.ReadLine();
                    var sw =File.CreateText(filename);
                    sw.Close();
                    noException = true;
                }
                catch (UnauthorizedAccessException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You're not autorized to create this file");
                    
                }
                catch (DirectoryNotFoundException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The direcory you've entered is not found");
                    

                }
                catch (ArgumentException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The filename is not valid");
                    

                }
                catch (SystemException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The filename is not valid");


                }
            } while (noException == false);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"The file '{filename}' is now created");

            Console.Write("Enter text you wish to save in your file: ");
            
            File.WriteAllText(filename, Console.ReadLine()); 

            





        }
    }
}
