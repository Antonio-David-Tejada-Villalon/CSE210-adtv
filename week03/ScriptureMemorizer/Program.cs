// Program.cs
using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a scripture library and load scriptures from file
            var library = new ScriptureLibrary();
            library.LoadScripturesFromFile("scriptures.txt");

            Console.WriteLine("Welcome to the Scripture Memorizer!");
            Console.WriteLine("Press Enter to hide words, or type 'quit' to exit.");
            Console.WriteLine();

            while (true)
            {
                var scripture = library.GetRandomScripture();
                if (scripture == null)
                {
                    Console.WriteLine("No scriptures available in the library.");
                    break;
                }

                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();

                while (!scripture.AllWordsHidden())
                {
                    Console.Write("Press Enter to hide more words, or type 'quit' to exit: ");
                    var input = Console.ReadLine();

                    if (input?.Trim().ToLower() == "quit")
                    {
                        Console.WriteLine("Thank you for using the Scripture Memorizer. Goodbye!");
                        return;
                    }

                    scripture.HideRandomWords(3);
                    Console.Clear();
                    Console.WriteLine(scripture.GetDisplayText());
                    Console.WriteLine();
                }

                Console.WriteLine("Congratulations! You've memorized the entire scripture.");
                Console.Write("Would you like to try another scripture? (y/n): ");

                // 👇 PROFESSIONAL INPUT HANDLING: Clear buffer + read line + validate
                ClearInputBuffer();
                var continueChoice = Console.ReadLine()?.Trim().ToLower() ?? "";

                if (continueChoice is "y" or "yes")
                {
                    continue; // 👈 Loop back to get new scripture
                }
                else
                {
                    Console.WriteLine("Thank you for using the Scripture Memorizer. Goodbye!");
                    break;
                }
            }

            // 👇 Keep terminal open for user
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(intercept: true);
        }

        /// <summary>
        /// Clears any leftover keystrokes from the input buffer.
        /// Prevents issues where Console.ReadLine() reads stale input.
        /// </summary>
        private static void ClearInputBuffer()
        {
            while (Console.KeyAvailable)
            {
                _ = Console.ReadKey(intercept: true); // Discard key without echoing
            }
        }
    }
}