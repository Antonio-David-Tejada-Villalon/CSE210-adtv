// SimpleGoal.cs
namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        // Constructor
        public SimpleGoal(string shortName, string description, int points)
            : base(shortName, description, points)
        {
        }

        // 👇 POLYMORPHISM: Override RecordEvent()
        public override void RecordEvent()
        {
            SetComplete(true);
        }

        // 👇 POLYMORPHISM: Override GetDetailsString()
        public override string GetDetailsString()
        {
            return $"{GetStatusIcon()} {GetShortName()} ({GetDescription()})";
        }

        // 👇 POLYMORPHISM: Override GetStringRepresentation()
        public override string GetStringRepresentation()
        {
            return $"SimpleGoal:{GetShortName()},{GetDescription()},{GetPoints()},{IsComplete()}";
        }
    }
}