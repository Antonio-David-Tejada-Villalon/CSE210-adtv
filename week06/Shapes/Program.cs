// Program.cs
using System;
using System.Collections.Generic;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Shape Area Calculator ===\n");

            // 👇 POLYMORPHIC LIST: Holds different shapes, but all are treated as Shape
            List<Shape> shapes = new List<Shape>();

            // Create shapes and add them to the list
            shapes.Add(new Square("Red", 5.0));
            shapes.Add(new Rectangle("Blue", 4.0, 6.0));
            shapes.Add(new Circle("Green", 3.0));

            // 👇 ITERATE AND CALL POLYMORPHIC METHODS
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Color: {shape.GetColor()}");
                Console.WriteLine($"Type: {shape.GetType().Name}");
                Console.WriteLine($"Area: {shape.GetArea():F2} square units");
                Console.WriteLine();
            }

            Console.WriteLine("Program complete.");
        }
    }
}