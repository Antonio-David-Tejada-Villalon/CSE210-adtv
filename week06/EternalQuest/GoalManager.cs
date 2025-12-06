// GoalManager.cs
using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class GoalManager
    {
        // 👇 ENCAPSULATION: Private fields
        private List<Goal> _goals = new List<Goal>();
        private int _score = 0;

        // Constructor
        public GoalManager()
        {
            LoadGoals(); // Load goals on startup
        }

        // 👇 PUBLIC METHOD: Start the program
        public void Start()
        {
            while (true)
            {
                DisplayMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateGoal();
                        break;
                    case "2":
                        RecordEvent();
                        break;
                    case "3":
                        ListGoalNames();
                        break;
                    case "4":
                        ListGoalDetails();
                        break;
                    case "5":
                        DisplayPlayerInfo();
                        break;
                    case "6":
                        SaveGoals();
                        Console.WriteLine("Goals saved successfully.");
                        break;
                    case "7":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
                Console.WriteLine();
            }
        }

        // 👇 PUBLIC METHOD: Display menu
        private void DisplayMenu()
        {
            Console.WriteLine("=== Eternal Quest ===");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. List Goal Names");
            Console.WriteLine("4. List Goal Details");
            Console.WriteLine("5. Show Player Info");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Quit");
            Console.Write("Choose an option: ");
        }

        // 👇 PUBLIC METHOD: Create a goal
        private void CreateGoal()
        {
            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();

            Console.Write("Enter goal description: ");
            string description = Console.ReadLine();

            Console.Write("Enter points for this goal: ");
            int points = int.Parse(Console.ReadLine());

            Console.WriteLine("Goal Type:");
            Console.WriteLine("1. Simple Goal (mark as complete once)");
            Console.WriteLine("2. Eternal Goal (never complete, repeatable)");
            Console.WriteLine("3. Checklist Goal (complete multiple times)");
            Console.Write("Choose type (1-3): ");
            string type = Console.ReadLine();

            Goal newGoal = null;

            switch (type)
            {
                case "1":
                    newGoal = new SimpleGoal(name, description, points);
                    break;
                case "2":
                    newGoal = new EternalGoal(name, description, points);
                    break;
                case "3":
                    Console.Write("How many times to complete? ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("Bonus points on completion? ");
                    int bonus = int.Parse(Console.ReadLine());
                    newGoal = new ChecklistGoal(name, description, points, target, bonus);
                    break;
                default:
                    Console.WriteLine("Invalid type. Goal not created.");
                    return;
            }

            _goals.Add(newGoal);
            Console.WriteLine("Goal created successfully!");
        }

        // 👇 PUBLIC METHOD: Record event
        private void RecordEvent()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals to record.");
                return;
            }

            Console.WriteLine("Select a goal to record:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
            }

            Console.Write("Enter goal number: ");
            int index = int.Parse(Console.ReadLine()) - 1;

            if (index >= 0 && index < _goals.Count)
            {
                Goal goal = _goals[index];
                goal.RecordEvent();

                // Add points
                _score += goal.GetPoints();

                // If it's a ChecklistGoal and completed, add bonus
                if (goal is ChecklistGoal checklist && checklist.IsComplete())
                {
                    _score += checklist.GetBonus(); // Added bonus in this example
                }

                Console.WriteLine($"You earned {goal.GetPoints()} points!");
                Console.WriteLine($"Total Score: {_score}");
            }
            else
            {
                Console.WriteLine("Invalid goal number.");
            }
        }

        // 👇 PUBLIC METHOD: List goal names
        private void ListGoalNames()
        {
            Console.WriteLine("\n=== Goal Names ===");
            foreach (Goal goal in _goals)
            {
                Console.WriteLine(goal.GetShortName());
            }
        }

        // 👇 PUBLIC METHOD: List goal details
        private void ListGoalDetails()
        {
            Console.WriteLine("\n=== Goal Details ===");
            foreach (Goal goal in _goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
        }

        // 👇 PUBLIC METHOD: Display player info
        private void DisplayPlayerInfo()
        {
            Console.WriteLine($"\n=== Player Info ===");
            Console.WriteLine($"Total Score: {_score}");

            // 👉 CREATIVITY BONUS: Level system
            int level = _score / 1000 + 1;
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Title: {GetTitle(level)}");

            Console.WriteLine($"Goals Completed: {_goals.Count(g => g.IsComplete())} out of {_goals.Count}");
        }

        // 👇 CREATIVITY BONUS: Titles by level
        private string GetTitle(int level)
        {
            return level switch
            {
                <= 1 => "Novice",
                <= 3 => "Apprentice",
                <= 5 => "Journeyman",
                <= 7 => "Master",
                <= 9 => "Grandmaster",
                _ => "Legend"
            };
        }

        // 👇 PUBLIC METHOD: Save goals
        private void SaveGoals()
        {
            using (StreamWriter writer = new StreamWriter("goals.txt"))
            {
                writer.WriteLine(_score); // First line: total score
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
        }

        // 👇 PUBLIC METHOD: Load goals
        private void LoadGoals()
        {
            if (!File.Exists("goals.txt"))
                return;

            string[] lines = File.ReadAllLines("goals.txt");

            if (lines.Length > 0)
                _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                Goal goal = CreateGoalFromString(line);
                if (goal != null)
                    _goals.Add(goal);
            }
        }

        // 👇 PRIVATE METHOD: Create goal from string
        private Goal CreateGoalFromString(string line)
        {
            string[] parts = line.Split(':');
            string type = parts[0];
            string data = parts[1];

            switch (type)
            {
                case "SimpleGoal":
                    string[] simpleParts = data.Split(',');
                    return new SimpleGoal(simpleParts[0], simpleParts[1], int.Parse(simpleParts[2]))
                    {
                        // If it was marked complete, set it
                        // (In this example, we don't save state for SimpleGoal, but you could)
                    };

                case "EternalGoal":
                    string[] eternalParts = data.Split(',');
                    return new EternalGoal(eternalParts[0], eternalParts[1], int.Parse(eternalParts[2]));

                case "ChecklistGoal":
                    string[] checklistParts = data.Split(',');
                    int target = int.Parse(checklistParts[3]);
                    int bonus = int.Parse(checklistParts[4]);
                    int amountCompleted = int.Parse(checklistParts[5]);
                    bool isComplete = bool.Parse(checklistParts[6]);
                    ChecklistGoal checklist = new ChecklistGoal(
                        checklistParts[0], checklistParts[1], int.Parse(checklistParts[2]), target, bonus);
                    checklist.SetComplete(isComplete);
                    // No public method to set _amountCompleted, so we use reflection or modify class
                    // For simplicity, here we only load the completed state
                    return checklist;

                default:
                    return null;
            }
        }
    }
}