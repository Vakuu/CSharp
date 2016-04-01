using System;

namespace _01_Point3D
{
    public class TestPoint3D
    {
        public static void Main()
        {
            Console.WriteLine("Enter point name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter z: ");
            int z = int.Parse(Console.ReadLine());
            Point3D p1 = new Point3D(x, y, z);
            Point3D zeroPoint = Point3D.StartingPoint;
            Console.WriteLine(zeroPoint);
            Console.WriteLine(p1);

        }
    }
}