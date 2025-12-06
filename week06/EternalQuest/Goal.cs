// Goal.cs
using System;

namespace EternalQuest
{
    public abstract class Goal
    {
        private string _shortName;
        private string _description;
        private int _points;
        private bool _isComplete;

        protected Goal(string shortName, string description, int points)
        {
            _shortName = shortName;
            _description = description;
            _points = points;
            _isComplete = false;
        }

        public string GetShortName() => _shortName;
        public string GetDescription() => _description;
        public int GetPoints() => _points;
        public bool IsComplete() => _isComplete;

        // 👇 CHANGED FROM protected TO public
        public void SetComplete(bool complete) => _isComplete = complete;

        public abstract void RecordEvent();
        public abstract string GetDetailsString();
        public abstract string GetStringRepresentation();

        public virtual string GetStatusIcon()
        {
            return _isComplete ? "[X]" : "[ ]";
        }
    }
}