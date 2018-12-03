using System;
using System.Linq;

namespace Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            // HowHaveYouSlept();
            //WhileLoop();
            //ForLoop();
            //ForeachLoop();
            //IfStatement();
            ConditionelOperator();

        }


        private static void HowHaveYouSlept()
        {

            Console.Write("When did you go to bed yesterday? ");
            int bedTime = int.Parse(Console.ReadLine());

            Console.Write("When did you wake up? ");
            int wakeUpTime = int.Parse(Console.ReadLine());

            Console.Write("For how long do you usally sleep? ");
            int normalSleep = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int sleptHours;


            if (bedTime <= wakeUpTime)

                sleptHours = wakeUpTime - bedTime;
                
            else

                sleptHours = 24 - bedTime + wakeUpTime;


            Console.ForegroundColor = ConsoleColor.Green;

            if (sleptHours < (normalSleep -1))

                Console.WriteLine($"You've only slept {sleptHours} hours. Go back to bed!");

            else if (sleptHours > (normalSleep +1))

                Console.WriteLine($"You've slept {sleptHours} hours. That's a lot.");

            else

                Console.WriteLine($"You have slept well. ({sleptHours} hours)");

            Console.WriteLine();

            Console.ResetColor();

            

        }


        private static void WhileLoop()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("TimeSpan to repeat: ");

            int timesToRepeat = int.Parse(Console.ReadLine());


            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;

            int i = 0;
            while (i < timesToRepeat)
            {

                i++;
                Console.WriteLine($"Your name is {name}");

            } 

            
            Console.WriteLine();
            Console.ResetColor();


        }

        private static void ForLoop()
        {

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Times to repeat rows: ");

            int timesToRepeatRows = int.Parse(Console.ReadLine());

            Console.Write("Times to repeat columns: ");

            int timesToRepeatColumns = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            

            
            

            for (int i = 0; i<timesToRepeatRows; i++)
            {
                for (int j = 0; j < timesToRepeatColumns; j++)
                    Console.Write($"{name}     ");
                Console.WriteLine();

            }

            Console.WriteLine();
            Console.ResetColor();


        }

        private static void ForeachLoop()
        {
            

            
            Console.Write("Enter names in a list (like Maria,Peter,Lisa): ");
            string input = Console.ReadLine();
            input = input.Trim();
            string inputLower = input.ToLower();
            string[] namesLower = inputLower.Split(',');
            string[] names = input.Split(',');
            
            bool allowZelda = false;



                

            Console.Write("What surname do they have? ");
            string surname = Console.ReadLine();
            
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (string value in namesLower)

                if (value == "allowzelda")
                    allowZelda = true;


            if (allowZelda = true)
            {

                foreach (string value in names)
                {
                    if(value != "AllowZelda")

                    Console.WriteLine($"{value} {surname}");

                }
            }

            else
            {


                foreach (string value in names)
                {

                    


                    if (value == "zelda" || value == "Zelda" )
                        break;

                    Console.WriteLine($"{value} {surname}");

                }
            }
            Console.WriteLine();
            Console.ResetColor();


        }
            private static void IfStatement()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            bool answer = false;


            for (int i = 0; i < 6; i++)
            {


                

                

                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                if (number == randomNumber)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You have guessed the right number!");
                    i = 6;
                    answer = true;

                }
                else if (number < randomNumber)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You guessed to low");
                    Console.WriteLine();
                    Console.ResetColor();


                }
                else 
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You guessed to high");
                    Console.WriteLine();
                    Console.ResetColor();


                }
            }

                if(answer == false)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Game Over");
                    Console.WriteLine();
                    Console.ResetColor();


                }
            //Console.Write("Enter a number to compare to: ");
            //int reference = int.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.ForegroundColor = ConsoleColor.Green;

            //if (number < reference)
            //{
            //    Console.WriteLine($"{number} is lower than {reference}");


            //}

            //else if (number > reference)
            //    {
            //    Console.WriteLine($"{number} is higher than {reference}");


            //    }
            //else Console.WriteLine($"{number} is equal to {reference}");

            Console.WriteLine();
            Console.ResetColor();
        }
        private static void ConditionelOperator()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter a number to compare to: ");
            int reference = int.Parse(Console.ReadLine());



            string message = (number <= reference)? ((number == reference)? "Eqauls to ":"Lower than ") : "Higher than ";

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message + reference);
            Console.WriteLine();
            Console.ResetColor();


        }

    }
}
