// Activity.cs
using System;

namespace ExerciseTracking
{
    public abstract class Activity
    {
        // 👇 ENCAPSULATION: Private fields
        private DateTime _date;
        private int _minutes;

        // Constructor
        protected Activity(DateTime date, int minutes)
        {
            _date = date;
            _minutes = minutes;
        }

        // Getters (Encapsulation)
        public DateTime GetDate() => _date;
        public int GetMinutes() => _minutes;

        // 👇 POLYMORPHISM: Abstract methods — must be overridden
        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        // 👇 POLYMORPHISM: Virtual method — can be overridden if needed
        public virtual string GetSummary()
        {
            return $"{_date:dd MMM yyyy} {GetType().Name} ({_minutes} min) - " +
                   $"Distance {GetDistance():F1} km, Speed {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km";
        }
    }
}