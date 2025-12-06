// Shape.cs
using System;

namespace Shapes
{
    public abstract class Shape
    {
        // 👇 ENCAPSULATION: Private field
        private string _color;

        // Constructor that sets color
        public Shape(string color)
        {
            _color = color;
        }

        // Getter and setter for color
        public string GetColor()
        {
            return _color;
        }

        public void SetColor(string color)
        {
            _color = color;
        }

        // 👇 POLYMORPHISM: Abstract method to calculate area
        public abstract double GetArea();
    }
}