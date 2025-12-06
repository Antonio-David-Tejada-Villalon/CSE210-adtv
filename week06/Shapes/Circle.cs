// Circle.cs
using System;

namespace Shapes
{
    public class Circle : Shape
    {
        // 👇 ENCAPSULATION: Private field
        private double _radius;

        // Constructor: pass color to base, store radius
        public Circle(string color, double radius) : base(color)
        {
            _radius = radius;
        }

        // 👇 POLYMORPHISM: Override GetArea() for circle
        public override double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}