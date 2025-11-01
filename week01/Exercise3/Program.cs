using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare a variable to control whether the user wants to play again
        string playAgain = "yes";

        // Start the main game loop: keep playing as long as user says "yes"
        do
        {
            // Create a new Random object to generate random numbers
            Random random = new Random();

            // Generate a random number between 1 and 100 (inclusive)
            int numberToGuess = random.Next(1, 101);

            // Initialize variables for user guess and number of attempts
            int userGuess = 0; // User's current guess
            int attempts = 0;  // Number of attempts made

            // Welcome message to the user
            Console.WriteLine("\nWelcome to the Number Guessing Game!");
            Console.WriteLine("I have selected a number between 1 and 100. Can you guess it?");

            // Loop until the user guesses the correct number
            while (userGuess != numberToGuess)
            {
                // Prompt the user to enter their guess
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                // Try to parse the input to an integer
                if (int.TryParse(input, out userGuess))
                {
                    attempts++; // Increment the number of attempts

                    // Check if the guess is correct, too high, or too low
                    if (userGuess < numberToGuess)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else if (userGuess > numberToGuess)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You've guessed the number {numberToGuess} in {attempts} attempts.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            // After the user guesses correctly, ask if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower(); // Convert to lowercase for easier comparison

        } while (playAgain == "yes"); // <-- This is now correctly attached to the do

        // Farewell message
        Console.WriteLine("Thank you for playing! Goodbye!");

        // Optional: Pause before closing
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}