using System;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cleanArray;
            bool validInput;

            char separator = AskUserForSeparator();
            bool errorMessage = AskUserForErrorMessage();

            do
            {
                Console.ResetColor();
                string response = GetInputFromUser();
                string[] peopleArray = CreateArrayOfPeolple(response, separator);
                cleanArray = CleanUserInput(peopleArray);                
                validInput = ValidateInput(cleanArray, errorMessage);
            } while (validInput == false);
            
            RespondToUser(cleanArray);
        }

        private static bool AskUserForErrorMessage()
        {
            bool errorMessage = true;
            Console.Write("Do you want to see error messages (default is yes)");
            string answer = Console.ReadLine();
            answer = answer.ToLower().Trim();

            if (answer == "no" || answer == "n")
                errorMessage = false;

            return errorMessage;
        }

        private static char AskUserForSeparator()
        {
            Console.Write("Which separator do you want to use (default is comma) ?");
            char separator;
            bool answer = false;
            answer = char.TryParse(Console.ReadLine(), out separator);
            if (answer == false)
                separator = ',';
            
            return separator;

        }

        private static bool ValidateInput(string[] cleanArray, bool message)
        {
            bool ok = true;
            string errorMessage = "";
            if (cleanArray.Length == 1 && cleanArray[0] == "")
            {                
                errorMessage = "The list don't contain any names";
                ok = false;
            }

            else
            {
                foreach (var item in cleanArray)
                {
                    if (item.Length < 2 || item.Length > 9)
                    {                        
                        errorMessage = "A name can only have 2 to 9 letters";
                        ok = false;                        
                    }
                }
            }

            if (ok == false && message == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(errorMessage);
            }
            return ok;
        }

        private static string  GetInputFromUser()
        {
            Console.Write("Enter a list of names: ");
            string input = Console.ReadLine();            
            return input;
        }

        

        private static string[] CreateArrayOfPeolple(string response , char separtor)
        {            
            string[] peopleArray = response.Split(separtor);
            return peopleArray;
        }

        private static string[] CleanUserInput(string[] peopleArray)
        {
            int i = 0;
            foreach (var item in peopleArray)
            {
                peopleArray[i] = item.Trim().ToUpper();
                i++;
            }
            return peopleArray;

        }



        private static void RespondToUser(string[] peopleArray)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            int i = 0;

            foreach (string value in peopleArray)
            {
                Console.WriteLine($"***SUPER-{value}***");
                i++;
            }           

            Console.WriteLine();
            Console.ResetColor();
        }  
    }
}
