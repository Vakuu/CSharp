using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsolationAndPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BasicShape> shapes = new List<BasicShape>()
                {
                 
                    new Rectangle(4.4, 9.3),
                    new Rectangle(1.4, 2.7),
                    new Rhombus(1.5, 2.0),
                    new Rhombus(6.8, 9.4)
                };

            foreach (BasicShape shape in shapes)
            {
                Console.WriteLine("Shape {0}\nPerimeter = {1}\nArea = {2}\n", shape.GetType().Name,
                    shape.CalculateArea(), shape.CalculatePerimeter());
            }
        }
    }
}
