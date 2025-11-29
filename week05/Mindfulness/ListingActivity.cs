// ListingActivity.cs
using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessProgram
{
    public class ListingActivity : Activity
    {
        // 👇 ENCAPSULATION: Private list of prompts — only used by this class
        private List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
        }

        public override void Start()
        {
            DisplayStartingMessage();

            Random random = new Random();
            string prompt = _prompts[random.Next(_prompts.Count)];
            Console.WriteLine($"\n--- {prompt} ---\n");

            Console.WriteLine("You may begin in:");
            ShowCountdown(5);

            Console.WriteLine("\nStart listing items (press Enter after each one). You have {0} seconds:", GetDuration());

            List<string> responses = new List<string>();
            DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string response = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(response))
                    responses.Add(response);
            }

            Console.WriteLine($"\nYou listed {responses.Count} items.");
            DisplayEndingMessage();
        }
    }
}