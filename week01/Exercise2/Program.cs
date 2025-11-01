using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage
        Console.Write("Please enter your grade percentage: ");
        string input = Console.ReadLine();
        double grade = double.Parse(input);

        // Determine the letter grade based on the percentage
        string letter;
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Stretch Challenge: Add +/- to the letter grade
        string sign = "";
        int lastDigit = (int)grade % 10;

        // Basic rule: + if last digit is >= 7, - if <3
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        // Special cases
        if (letter == "A")
        {
            //No A+ allowed
            if (sign == "+")
            {
                sign = "";
            }
        }
        else if (letter == "F")
        {
            //No +/- for F
            sign = "";
        }
        
        // Output the final letter grade
        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        //Check if the user passed
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass the course.");
        }
    }
}