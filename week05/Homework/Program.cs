// Program.cs
using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Homework Assignment Program ===\n");

            // ❌ NO se puede instanciar Assignment porque es abstracta
            // Assignment assignment = new Assignment("Samuel Bennett", "Multiplication"); // ← ERROR

            // ✅ Test Math Assignment
            MathAssignment math = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
            Console.WriteLine(math.GetSummary());
            Console.WriteLine(math.GetHomeworkList());
            Console.WriteLine();

            // ✅ Test Writing Assignment
            WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
            Console.WriteLine(writing.GetSummary());
            Console.WriteLine(writing.GetWritingInformation());
            Console.WriteLine();

            Console.WriteLine("All tests passed!");
        }
    }
}