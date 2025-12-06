// Square.cs
namespace Shapes
{
    public class Square : Shape
    {
        // 👇 ENCAPSULATION: Private field
        private double _side;

        // Constructor: pass color to base, store side
        public Square(string color, double side) : base(color)
        {
            _side = side;
        }

        // 👇 POLYMORPHISM: Override GetArea() for square
        public override double GetArea()
        {
            return _side * _side;
        }
    }
}