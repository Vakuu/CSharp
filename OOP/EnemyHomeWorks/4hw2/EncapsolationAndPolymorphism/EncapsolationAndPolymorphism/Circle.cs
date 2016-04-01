using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsolationAndPolymorphism
{ 
    class Circle : IShape
    {
        private double radious;

        public Circle(double radious)
        {
            this.Radious = radious;
        }

        public double Radious
        {
            get
            {
                return this.radious;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number must be positive");
                }
                this.radious = value;
            }
        }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(this.radious, 2);
        }
        public double CalculatePerimeter()
        {
            return Math.PI * this.radious * 2;
        }
    }
}
