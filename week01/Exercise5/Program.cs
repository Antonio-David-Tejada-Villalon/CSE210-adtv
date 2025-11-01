using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Call DisplayWelcome to show the welcome message
        DisplayWelcome();

        // 2. Call PromptUserName to get the user's name
        string userName = PromptUserName();

        // 3. Call PromptUserNumber to get the user's favorite number
        int favoriteNumber = PromptUserNumber();

        // 4. Call SquareNumber to compute the square of the favorite number
        int squaredNumber = SquareNumber(favoriteNumber);

        // 5. Call DisplayResult to show the final message
        DisplayResult(userName, squaredNumber);
    }

    // Function 1: DisplayWelcome - No parameters, no return value
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function 2: PromptUserName - Returns the user's name as a string
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Function 3: PromptUserNumber - Returns the user's favorite number as an integer
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // Function 4: SquareNumber - Accepts an integer, returns its square
    static int SquareNumber(int num)
    {
        return num * num;
    }

    // Function 5: DisplayResult - Accepts name and squared number, displays message
    static void DisplayResult(string name, int squared)
    {
        Console.WriteLine($"{name}, the square of your number is {squared}");
    }
}