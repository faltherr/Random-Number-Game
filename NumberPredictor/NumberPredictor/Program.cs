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
            // Call this function to display abstracted app info
            GetAppInfo();

            // This function will greet the user
            GreetUser();

            while (true)
            {

                //Set correct number
                //int correctNumber = 7;

                //Create a random object
                Random random = new Random();

                //This uses the random method Next to create a number between 1 and 10
                int correctNumber = random.Next(1, 11);
                
                // Init guess var
                int guess = 0;

                //Ask user for a number
                Console.WriteLine("Guess a number between 1 and 10");

                //While the guess is incorrect
                while (guess != correctNumber)
                {
                    // Grab user input
                    string numberInput = Console.ReadLine();

                    // Confirm user input is a number
                    if (!int.TryParse(numberInput, out guess))
                    {
                        //This prints an error message to the console if input is not an integer
                        PrintColorMessage(ConsoleColor.Red, "Please enter a valid number.");

                        //Proceed if conditional passes
                        continue;
                    }

                    // Cast to int and put in guess variable
                    guess = Int32.Parse(numberInput);

                    //Match the guess to the correct number
                    if (guess != correctNumber)
                    {
                        //This prints an error message to the console if the number is incorrect
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, try again!");
                    }
                }

                //Output success message
                PrintColorMessage(ConsoleColor.Green, "You win!");

                    //Ask user to continue
                    Console.WriteLine("Do you want to play again? [Y or N]");

                    string answer = Console.ReadLine().ToUpper();

                    if (answer == "Y"){
                        continue;
                    }
                    else if (answer == "N"){
                        return;
                    }
                    else
                    {
                        return;
                    }

                }
            }
        //Get and display app info
        static void GetAppInfo() {
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
        }

        // Ask user name and greet
        static void GreetUser(){
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            //Return user input
            Console.WriteLine("Hello {0}, let's play a game", inputName);
        }

        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message){
            //Change text color
            Console.ForegroundColor = color;

            //Tell user the input format is incorrect
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();
        }

    }
    }
