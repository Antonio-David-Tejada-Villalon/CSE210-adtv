// CyclingActivity.cs
namespace ExerciseTracking
{
    public class CyclingActivity : Activity
    {
        // 👇 ENCAPSULATION: Private field
        private double _speed; // in kph

        // Constructor
        public CyclingActivity(DateTime date, int minutes, double speed)
            : base(date, minutes)
        {
            _speed = speed;
        }

        // 👇 POLYMORPHISM: Override GetDistance()
        public override double GetDistance()
        {
            return (_speed * GetMinutes()) / 60; // km
        }

        // 👇 POLYMORPHISM: Override GetSpeed()
        public override double GetSpeed()
        {
            return _speed;
        }

        // 👇 POLYMORPHISM: Override GetPace()
        public override double GetPace()
        {
            return 60 / _speed; // min/km
        }

        // 👇 Optional: Override GetSummary() if you want custom format
        public override string GetSummary()
        {
            return $"{GetDate():dd MMM yyyy} Cycling ({GetMinutes()} min) - " +
                   $"Distance {GetDistance():F1} km, Speed {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km";
        }
    }
}