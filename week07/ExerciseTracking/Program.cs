// Program.cs
using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Exercise Tracking Program ===\n");

            // Create a list to hold activities
            List<Activity> activities = new List<Activity>();

            // Create one of each activity
            activities.Add(new RunningActivity(new DateTime(2022, 11, 3), 30, 3.0));
            activities.Add(new CyclingActivity(new DateTime(2022, 11, 3), 45, 15.0));
            activities.Add(new SwimmingActivity(new DateTime(2022, 11, 3), 60, 40));

            // Iterate through list and display summary
            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }

            Console.WriteLine("\nProgram complete.");
        }
    }
}