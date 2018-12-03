using System;

namespace Module2
{
    class Program
    {
        static void Main(string[] args)
        {
            //WhatsYourName();
            //Fruits();
            
            
        }
            private static void WhatsYourName()
            {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());

            if (name == "answer" || age == 42)
                Console.Beep(2836, 500);

            Console.Write("What is your favorite character? ");
            char letter = char.Parse(Console.ReadLine());

            Console.WriteLine("\nThank you!\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your name is: {name}");

            Console.WriteLine($"You have {65-age} years until retirement");

            if(char.IsNumber(letter))
                Console.WriteLine("You like numbers");

            else
                Console.WriteLine("You don't like numbers");

            Console.WriteLine();

            Console.ResetColor();
            }
        

            private static void Fruits()
            {
            //Console.Write("How many fruits do you want to add? ");
            //int antalFrukter = int.Parse(Console.ReadLine());

            //for (int i = 0; i < antalFrukter; i++)
            //{
            //    Console.Write($"Enter fruit {i+1}: ");
            //    string frukt[i] = Console.ReadLine();
            //}
            {

            }

            Console.Write("Enter fruit 1: ");
            string fruit1 = Console.ReadLine();

            Console.Write("Enter fruit 2: ");
            string fruit2 = Console.ReadLine();

            Console.Write("Enter fruit 3: ");
            string fruit3 = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;

            var mystring = $"You entered three fruits: {fruit1}, {fruit2}, {fruit3}!";


            Console.WriteLine(mystring);

            

            Console.WriteLine("You entered three fruits: " + fruit1 + ", " + fruit2 + ", " + fruit3 + "!");

            string s = String.Format("You entered three fruits: {0}, {1}, {2}!", fruit1, fruit2, fruit3);

            Console.WriteLine(s);

            Console.WriteLine();

            Console.ResetColor();



        }



    }
}
