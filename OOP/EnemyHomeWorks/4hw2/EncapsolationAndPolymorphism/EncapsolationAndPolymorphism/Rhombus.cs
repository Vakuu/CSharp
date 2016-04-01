using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsolationAndPolymorphism
{
    class Rhombus : BasicShape
    {
        private double a;
        private double b;

        public Rhombus(double a, double b)
        {
            this.A = a;
            this.B = b;

        }

        public double A 
        {
            get
            {
                return this.a;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number must be positive");
                }
                 this.a = value;
            }
        }
        public double B
        {
            get
            {
                return this.b;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number must be positive");
                }
                this.b = value;
            }
        }
       
        public override double CalculateArea()
        {
            return this.A * this.B;
        }
        public override double CalculatePerimeter()
        {
            return this.A * 4;
        }
    }
}
