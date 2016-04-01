using System;
using System.Collections.Generic;

namespace _01.Shapes
{
    class ShapesTest
    {
        static void Main()
        {
            Rectangle first = new Rectangle(5, 4);
            Rectangle third = new Rectangle(4.5, 6);
            Rhombus second = new Rhombus(4.4, 2);
            Rhombus fourth = new Rhombus(7, 0.5);
            Circle fifth = new Circle(5);
            Circle sixth = new Circle(3.4);

            List<IShape> shapes = new List<IShape>() { first, second, third, fourth, fifth, sixth };

            foreach (var shape in shapes)
            {
                Console.WriteLine("Area of the {0} is: {1:F2}", shape.GetType().Name, shape.CalculateArea());
                Console.WriteLine("Perimeter of the {0} is: {1:F2}\n{2}", shape.GetType().Name, shape.CalculatePerimeter(), new string('-', 13));
            }
        }
    }
}
