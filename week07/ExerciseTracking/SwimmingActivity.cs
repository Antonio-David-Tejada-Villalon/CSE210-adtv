// SwimmingActivity.cs
namespace ExerciseTracking
{
    public class SwimmingActivity : Activity
    {
        // 👇 ENCAPSULATION: Private field
        private int _laps;

        // Constructor
        public SwimmingActivity(DateTime date, int minutes, int laps)
            : base(date, minutes)
        {
            _laps = laps;
        }

        // 👇 POLYMORPHISM: Override GetDistance()
        public override double GetDistance()
        {
            return (_laps * 50) / 1000.0; // 50 meters per lap → convert to km
        }

        // 👇 POLYMORPHISM: Override GetSpeed()
        public override double GetSpeed()
        {
            return (GetDistance() / GetMinutes()) * 60; // km/h
        }

        // 👇 POLYMORPHISM: Override GetPace()
        public override double GetPace()
        {
            return GetMinutes() / GetDistance(); // min/km
        }

        // 👇 Optional: Override GetSummary() if you want custom format
        public override string GetSummary()
        {
            return $"{GetDate():dd MMM yyyy} Swimming ({GetMinutes()} min) - " +
                   $"Distance {GetDistance():F1} km, Speed {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km";
        }
    }
}