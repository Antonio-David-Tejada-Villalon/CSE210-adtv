// BreathingActivity.cs
using System;
using System.Threading;

namespace MindfulnessProgram
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {
        }

        public override void Start()
        {
            DisplayStartingMessage();

            int elapsed = 0;
            while (elapsed < GetDuration())
            {
                Console.Write("Breathe in... ");
                ShowCountdown(4);
                elapsed += 4;

                if (elapsed >= GetDuration()) break;

                Console.Write("Breathe out... ");
                ShowCountdown(6);
                elapsed += 6;
            }

            DisplayEndingMessage();
        }
    }
}