using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shapes.Shapes
{
    using Interfaces;

    class Circle : IShape
    {
        private double radius;
        public double Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Radius cannot be 0 or less.");
                }
                this.radius = value;
            }
        }
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }
        public double CalculatePerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }
    }
}
