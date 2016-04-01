using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Geometry3D
{
    public class Path3D
    {
        private List<Point3D> sequenceOfPoints;

        public Path3D(List<Point3D> sequenceOfPoints)
        {
            this.SequenceOfPoints = sequenceOfPoints;
        }

        public List<Point3D> SequenceOfPoints
        {
            get
            {
                return this.sequenceOfPoints;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("There is no path without points.");
                }

                this.sequenceOfPoints = value;
            }
        }
    }
}
