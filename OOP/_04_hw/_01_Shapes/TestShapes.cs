using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shapes
{
    using Interfaces;
    using Shapes;
    class TestShapes
    {
        static void Main(string[] args)
        {
            IShape[] shapes = 
            {
                new Rectangle(3, 1.5),
                new Rhombus(2, 4.1),
                new Circle(5100),
                new Circle(0.1)
            };
            foreach (IShape shape in shapes)
            {
                Console.WriteLine("{0}: Area - {1:F5}, Perimeter - {2:F5}", shape.GetType().Name, shape.CalculateArea(), shape.CalculatePerimeter());
            }
        }
    }
}
