using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Point3D
{
    public class Point3D
    {
        private static Point3D startingPoint = new Point3D(0, 0, 0);
        private int x;
        private int y;
        private int z;
        public int X
        {
            get { return this.x; }
            set
            {
                this.x = value;
            }
        }
        public int Y
        {
            get { return this.y; }
            set
            {
                this.y = value;
            }
        }
        public int Z
        {
            get { return this.z; }
            set
            {
                this.z = value;
            }
        }
        public static Point3D StartingPoint
        {
            get { return Point3D.startingPoint; }
        }
        public Point3D(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public void ToString()
        {
            Console.WriteLine("X= {0}", this.x);
            Console.WriteLine("Y= {0}", this.y);
            Console.WriteLine("Z= {0}", this.z);
        }
    }
}
