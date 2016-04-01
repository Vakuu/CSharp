using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Point3D;

namespace _03_Paths
{
    class Path3D
    {
        private List<Point3D> points;
        public List<Point3D> Points
        {
            get { return this.points; }
            set { this.points = value; }
        }
        public Path3D(List<Point3D> points)
        {
            this.Points = points;
        }
        public override string ToString()
        {
            string spoints = "";
            for (int i = 0; i < this.Points.Count; i++)
            {
                spoints += this.Points[i].X + "," + this.Points[i].Y + "," + this.Points[i].Z + "/";
            }
            spoints = spoints.Substring(0, spoints.Length - 1);
            return spoints;
        }
    }
}
