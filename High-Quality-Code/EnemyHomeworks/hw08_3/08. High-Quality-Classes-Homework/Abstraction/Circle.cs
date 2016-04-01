using System;

namespace Abstraction
{
    class Circle : ICircle
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {

            get { return this.radius; }
            set
            {
                if (value <= 0)
                {
                    throw new FormatException("Radious cannot be negative or zero.");
                }

                this.radius = value;
            }
        } 

        public double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.radius;

            return perimeter;
        }

        public double CalcSurface()
        {
            double surface = Math.PI * this.radius * this.radius;

            return surface;
        }

     
    }
}
