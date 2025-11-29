// Activity.cs
using System;
using System.Threading;

namespace MindfulnessProgram
{
    public abstract class Activity
    {
        // 👇 ENCAPSULATION: All member variables are private
        private string _name;
        private string _description;
        private int _duration;

        // Constructor requires parameters → ensures valid state
        protected Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        // Getters (Encapsulation)
        protected string GetName() => _name;
        protected string GetDescription() => _description;
        protected int GetDuration() => _duration;

        // Setters (Encapsulation)
        protected void SetDuration(int duration)
        {
            if (duration <= 0)
                throw new ArgumentException("Duration must be greater than zero.");
            _duration = duration;
        }

        // 👇 ABSTRACTION: Methods that will be implemented by derived classes
        public abstract void Start();

        // 👇 INHERITANCE: Shared behaviors defined in base class
        protected void ShowSpinner(int seconds)
        {
            Console.Write("⏳ ");
            for (int i = 0; i < seconds; i++)
            {
                foreach (char c in "|/-\\")
                {
                    Console.Write(c);
                    Thread.Sleep(250);
                    Console.Write("\b");
                }
            }
            Console.WriteLine();
        }

        protected void ShowCountdown(int seconds)
        {
            Console.Write("⏳ Countdown: ");
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b");
            }
            Console.WriteLine("0");
        }

        protected void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_name} Activity.\n");
            Console.WriteLine(_description);
            Console.Write("\nHow long, in seconds, would you like to do this activity? ");
            int duration = int.Parse(Console.ReadLine());
            SetDuration(duration);
            Console.Clear();
            Console.WriteLine("Get ready...");
            ShowSpinner(3);
        }

        protected void DisplayEndingMessage()
        {
            Console.WriteLine("\nWell done!");
            ShowSpinner(2);
            Console.WriteLine($"\nYou completed {_name} for {_duration} seconds.");
            ShowCountdown(3);
        }
    }
}