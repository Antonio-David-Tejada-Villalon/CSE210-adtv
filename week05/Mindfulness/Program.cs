// Program.cs
using System;

namespace MindfulnessProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Mindfulness Program!\n");

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflecting Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Quit");
                Console.Write("Choose an activity (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BreathingActivity breathing = new BreathingActivity();
                        breathing.Start();
                        break;
                    case "2":
                        ReflectingActivity reflecting = new ReflectingActivity();
                        reflecting.Start();
                        break;
                    case "3":
                        ListingActivity listing = new ListingActivity();
                        listing.Start();
                        break;
                    case "4":
                        Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.\n");
                        continue;
                }

                Console.WriteLine();
            }
        }
    }
}