// Rectangle.cs
namespace Shapes
{
    public class Rectangle : Shape
    {
        // 👇 ENCAPSULATION: Private fields
        private double _length;
        private double _width;

        // Constructor: pass color to base, store length and width
        public Rectangle(string color, double length, double width) : base(color)
        {
            _length = length;
            _width = width;
        }

        // 👇 POLYMORPHISM: Override GetArea() for rectangle
        public override double GetArea()
        {
            return _length * _width;
        }
    }
}