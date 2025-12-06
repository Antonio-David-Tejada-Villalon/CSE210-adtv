// RunningActivity.cs
namespace ExerciseTracking
{
    public class RunningActivity : Activity
    {
        // 👇 ENCAPSULATION: Private field
        private double _distance; // in kilometers

        // Constructor
        public RunningActivity(DateTime date, int minutes, double distance)
            : base(date, minutes)
        {
            _distance = distance;
        }

        // 👇 POLYMORPHISM: Override GetDistance()
        public override double GetDistance()
        {
            return _distance;
        }

        // 👇 POLYMORPHISM: Override GetSpeed()
        public override double GetSpeed()
        {
            return (_distance / GetMinutes()) * 60; // km/h
        }

        // 👇 POLYMORPHISM: Override GetPace()
        public override double GetPace()
        {
            return GetMinutes() / _distance; // min/km
        }

        // 👇 Optional: Override GetSummary() if you want custom format
        public override string GetSummary()
        {
            return $"{GetDate():dd MMM yyyy} Running ({GetMinutes()} min) - " +
                   $"Distance {GetDistance():F1} km, Speed {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km";
        }
    }
}