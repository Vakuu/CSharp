using _01_Point3D;
using System;

namespace _02_DistanceCalculator
{
    public class TestPoint3D
    {
        public static void Main()
        {

            Point3D p1 = new Point3D(7.5, 86, 10.4);
            Point3D p2 = new Point3D(-1, 37, -89.9);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            double distance = DistanceCalculator.CalcDistance(p1, p2);
            Console.WriteLine("Distance is: " + distance);
        }
    }
}