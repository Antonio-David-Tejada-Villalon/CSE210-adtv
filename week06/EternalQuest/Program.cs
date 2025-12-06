// Program.cs

/*
 * CREATIVITY BONUS:
 * 1. Added a leveling system based on score (every 1000 points = 1 level).
 * 2. Each level has a fun title (Novice, Apprentice, Master, Legend).
 * 3. When a ChecklistGoal is completed, it gives extra bonus points.
 * 4. All goals are saved/loaded with their state (including progress for ChecklistGoal).
 * 5. Colorful prompts and user-friendly menu system.
 */
using System;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Eternal Quest Program!\n");

            GoalManager manager = new GoalManager();
            manager.Start();
        }
    }
}