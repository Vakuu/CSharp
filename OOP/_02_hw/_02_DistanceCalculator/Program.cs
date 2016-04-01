using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Point3D;

namespace _02_DistanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D(5, 0, 0);
            p1.ToString();
            Point3D p0 = Point3D.StartingPoint;
            p0.ToString();
            double d = DistanceCalculator.getDistance(p0, p1);
            Console.WriteLine(d);
        }
    }
}
