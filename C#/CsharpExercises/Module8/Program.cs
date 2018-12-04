using System;

namespace Module8
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal antalPersoner = 1M;
            Console.WriteLine("The chocolate contains 24 pieces");
            Console.Write("How many want to share? ");
            Console.ForegroundColor = ConsoleColor.Green;

            try
            {
            antalPersoner = decimal.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong input format");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            if (antalPersoner < 0)
            {
                throw new ArgumentException("Antal personer får inte vara negativt");
                
            }

            try
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                decimal result = 24/antalPersoner;
                Console.WriteLine($"Everyone get {result:.##} pieces");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex);
            }

            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Zero people can't divide a chocolate");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine();
        }
    }
}
