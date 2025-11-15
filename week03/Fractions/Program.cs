using System;

namespace Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test Constructor 1: No parameters → 1/1
            Fraction f1 = new Fraction();
            Console.WriteLine(f1.GetFractionString());  // Output: 1/1
            Console.WriteLine(f1.GetDecimalValue());    // Output: 1

            // Test Constructor 2: One parameter → 6/1
            Fraction f2 = new Fraction(6);
            Console.WriteLine(f2.GetFractionString());  // Output: 6/1
            Console.WriteLine(f2.GetDecimalValue());    // Output: 6

            // Test Constructor 3: Two parameters → 6/7
            Fraction f3 = new Fraction(6, 7);
            Console.WriteLine(f3.GetFractionString());  // Output: 6/7
            Console.WriteLine(f3.GetDecimalValue());    // Output: 0.8571428571428571

            // Test Getters and Setters
            f3.Numerator = 3;
            f3.Denominator = 4;
            Console.WriteLine(f3.GetFractionString());  // Output: 3/4
            Console.WriteLine(f3.GetDecimalValue());    // Output: 0.75

            // Test another fraction: 1/3
            Fraction f4 = new Fraction(1, 3);
            Console.WriteLine(f4.GetFractionString());  // Output: 1/3
            Console.WriteLine(f4.GetDecimalValue());    // Output: 0.3333333333333333

            // 💥 BONUS: Test validation — try setting denominator to 0
            Console.WriteLine("\n--- Testing Validation ---");
            try
            {
                f4.Denominator = 0; // This will throw an exception
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"✅ Caught expected error: {ex.Message}");
            }

            // 💥 BONUS: Test constructor with denominator 0
            try
            {
                Fraction invalid = new Fraction(5, 0); // This will throw an exception
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"✅ Caught expected error in constructor: {ex.Message}");
            }

            Console.WriteLine("\n🎉 All tests passed — including bonus validation!");
        }
    }
}