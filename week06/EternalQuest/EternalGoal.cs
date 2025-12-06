// EternalGoal.cs
namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        // Constructor
        public EternalGoal(string shortName, string description, int points)
            : base(shortName, description, points)
        {
        }

        // 👇 POLYMORPHISM: Override RecordEvent()
        public override void RecordEvent()
        {
            // Eternal goals never complete — just record event
            Console.WriteLine($"You recorded {GetShortName()} — keep going!");
        }

        // 👇 POLYMORPHISM: Override GetDetailsString()
        public override string GetDetailsString()
        {
            return $"{GetStatusIcon()} {GetShortName()} ({GetDescription()}) — Eternal";
        }

        // 👇 POLYMORPHISM: Override GetStringRepresentation()
        public override string GetStringRepresentation()
        {
            return $"EternalGoal:{GetShortName()},{GetDescription()},{GetPoints()}";
        }
    }
}