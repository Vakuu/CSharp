using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsolationAndPolymorphism
{
    class Rectangle : BasicShape
    {
        public Rectangle(double width, double heigh) 
        {
            this.Width = width;
            this.Heigh = heigh;
        }
        public override double CalculateArea()
        {
            return this.Width * this.Heigh;
        }
        public override double CalculatePerimeter()
        {
            return (this.Heigh + this.Width) * 2;
        }
    }
}
