// ChecklistGoal.cs
namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;

        public ChecklistGoal(string shortName, string description, int points, int target, int bonus)
            : base(shortName, description, points)
        {
            _target = target;
            _bonus = bonus;
            _amountCompleted = 0;
        }

        public override void RecordEvent()
        {
            _amountCompleted++;
            if (_amountCompleted >= _target)
            {
                SetComplete(true);
                Console.WriteLine($"🎉 Congratulations! You completed {GetShortName()} and earned a {_bonus} point bonus!");
            }
        }

        public override string GetDetailsString()
        {
            string status = IsComplete() ? "[X]" : "[ ]";
            return $"{status} {GetShortName()} ({GetDescription()}) — Completed {_amountCompleted}/{_target}";
        }

        public override string GetStringRepresentation()
        {
            return $"ChecklistGoal:{GetShortName()},{GetDescription()},{GetPoints()},{_target},{_bonus},{_amountCompleted},{IsComplete()}";
        }

        // 👇 ADD THIS METHOD TO FIX ERROR 1
        public int GetBonus()
        {
            return _bonus;
        }

        public int GetAmountCompleted() => _amountCompleted;
        public int GetTarget() => _target;
    }
}