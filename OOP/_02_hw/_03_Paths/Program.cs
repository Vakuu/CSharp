using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Point3D;

namespace _03_Paths
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D(1, 2, 3);
            Point3D p2 = new Point3D(2, 2, 3);
            List<Point3D> list = new List<Point3D> { p1, p2 };
            Path3D path = new Path3D(list);
            Storage.Save(path, @"C:\Users\Vak\Desktop\New folder\_02_hw\_03_Paths\");
            Path3D loadedPath=new Path3D(Storage.Load(@"C:\Users\Vak\Desktop\New folder\_02_hw\_03_Paths\filePath0.txt"));
            Console.WriteLine("Loaded points from the file: "+loadedPath.ToString());
        }
    }
}
