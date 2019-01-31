using System;

//Namespace
namespace NumberPredictor
{
    //Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            //Set app vars
            string appName = "Number Predictor";
            string appVersion = "0.0.1";
            string appAuthor = "Forest Altherr";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Magenta;

            //Write out app information
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();

            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            //Return user input
            Console.WriteLine("Hello {0}, let's play a game", inputName);

            //Set correct number
            int correctNumber = 7;

            // Init guess var
            int guess = 0;

            //Ask user for a number
            Console.WriteLine("Guess a number between 1 and 10");

            //While the guess is incorrect
            while(guess != correctNumber){
                // Grab user input
                string numberInput = Console.ReadLine();

                // Confirm user input is a number
                if (!int.TryParse(numberInput, out guess)) {
                    //Change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    //Tell user the input format is incorrect
                    Console.WriteLine("Please enter a number");

                    //Reset text color
                    Console.ResetColor();

                    //Proceed if conditional passes
                    continue;
                }

                // Cast to int and put in guess variable
                guess = Int32.Parse(numberInput);

                //Match the guess to the correct number
                if(guess != correctNumber) {
                    //Change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    //Error message for wrong number
                    Console.WriteLine("Wrong number, try again!");

                    //Reset text color
                    Console.ResetColor();
                }
            }

            //Output success message

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Output success message
            Console.WriteLine("You are correct!");

            //Reset text color
            Console.ResetColor();


        }
    }
}
