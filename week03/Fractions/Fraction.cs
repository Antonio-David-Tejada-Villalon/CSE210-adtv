namespace Fractions
{
    public class Fraction
    {
        // Private attributes (encapsulation)
        private int _numerator;
        private int _denominator;

        // Constructor: no parameters → initializes to 1/1
        public Fraction()
        {
            _numerator = 1;
            _denominator = 1;
        }

        // Constructor: one parameter (numerator) → denominator = 1
        public Fraction(int numerator)
        {
            _numerator = numerator;
            _denominator = 1;
        }

        // Constructor: two parameters (numerator and denominator)
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Denominator cannot be zero.");

            _numerator = numerator;
            _denominator = denominator;
        }

        // Getter and Setter for Numerator
        public int Numerator
        {
            get { return _numerator; }
            set { _numerator = value; }
        }

        // Getter and Setter for Denominator — with validation
        public int Denominator
        {
            get { return _denominator; }
            set 
            { 
                if (value == 0)
                    throw new ArgumentException("Denominator cannot be zero.");
                _denominator = value; 
            }
        }

        // Method to return fraction as string (e.g., "3/4")
        public string GetFractionString()
        {
            return $"{_numerator}/{_denominator}";
        }

        // Method to return decimal value (e.g., 0.75)
        public double GetDecimalValue()
        {
            return (double)_numerator / _denominator;
        }
    }
}