using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Point3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D(5, 4, 3);
            p1.ToString();
            Point3D p0 = Point3D.StartingPoint;
            p0.ToString();
        }
    }
}
