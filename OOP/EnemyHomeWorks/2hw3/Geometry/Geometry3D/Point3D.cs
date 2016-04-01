using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Geometry3D
{
    public class Point3D
    {
        private double x;
        private double y;
        private double z;

        private static readonly Point3D startingPoint = new Point3D(0, 0, 0);

        public static Point3D StartingPoint
        {
            get
            {
                return startingPoint;
            }
        }

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X
        {
            get
            {
                return this.x;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The coordinate cannot be negative.");
                }

                this.x = value;
            }
        }

        public double Y
        {
            get
            {
                return this.y;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The coordinate cannot be negative.");
                }

                this.y = value;
            }
        }

        public double Z
        {
            get
            {
                return this.z;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The coordinate cannot be negative.");
                }

                this.z = value;
            }
        }

        public override string ToString()
        {
            string point3dData;

            point3dData = "X = " + X + " ; " + "Y = " + Y + " ; " + "Z = " + Z;

            return point3dData;
        }
    }
}
