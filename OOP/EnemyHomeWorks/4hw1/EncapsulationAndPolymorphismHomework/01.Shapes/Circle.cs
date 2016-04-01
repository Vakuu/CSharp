using System;

namespace _01.Shapes
{
    class Circle : IShape
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }
    }
}
