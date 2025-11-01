using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished:");

        List<int> numbers = new List<int>(); // Create an empty list to store numbers

        int number;

        do
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0) // Only add non-zero numbers
            {
                numbers.Add(number); // Add the number to the list if it's not 0
            }
        } while (number != 0); // Continue until the user enters 0

        // 1. Compute the sum of the numbers
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        // 2. Compute the average of the numbers
        double average = (double)sum / numbers.Count;

        // 3. Find the maximum number
        int max = numbers[0]; // Assume first number is the largest

        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        // Showing the results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The maximum number is: {max}");

        // 4. Smallest number
        int min = numbers[0]; // Assume first number is the smallest
        bool firstIteration = true;

        foreach (int num in numbers)
        {
            if (firstIteration)
            {
                min = num; // Initialize min on first iteration
                firstIteration = false;
            }
            else if (num < min)
            {
                min = num;
            }
        }

        if (!firstIteration)
        {
            Console.WriteLine($"The minimum number is: {min}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }

        // 5. Display the numbers in ascending order
        numbers.Sort(); // Sort the list in ascending order

        Console.WriteLine("Numbers in ascending order:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("Thank you for using the number analyzer!");
        Console.WriteLine("Goodbye! Press any key to exit.");
        Console.ReadKey(); 
    }
}