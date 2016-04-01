using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Geometry.Geometry3D;

namespace Geometry.Geometry.Storage
{
    public static class Storage
    {
        public static string Save3dPoints(Path3D path)
        {
            try
            {
                FileStream stream = new FileStream("3DPaths.txt", FileMode.Create);

                StreamWriter sw = new StreamWriter(stream);

                foreach (Point3D currentPoint in path.SequenceOfPoints)
                {
                    sw.Write(currentPoint.X);
                    sw.Write(" ");
                    sw.Write(currentPoint.Y);
                    sw.Write(" ");
                    sw.Write(currentPoint.Z);
                    sw.WriteLine();
                }

                sw.Close();
                stream.Close();
            }
            catch(Exception)
            {
                string message = "There are some problems. Sequence wasnt saved.";

                return message;
            }

            string confirmation = "Sequence saved.";

            return confirmation;
        }

        public static Path3D Load3dPoints()
        {
            FileStream stream = new FileStream("3DPaths.txt", FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(stream);

            List<Point3D> loadedPoints = new List<Point3D>();

            while(!sr.EndOfStream)
            {
                string[] currentCoordinatesString = sr.ReadLine().Split(' ');

                double[] currentCoordinatesDouble = new double[3];

                for (int i = 0; i < currentCoordinatesDouble.Length; i++)
                {
                    currentCoordinatesDouble[i] = Convert.ToDouble(currentCoordinatesString[i]);
                }

                Point3D currentPoint = new Point3D(currentCoordinatesDouble[0], currentCoordinatesDouble[1], currentCoordinatesDouble[2]);

                loadedPoints.Add(currentPoint);
            }

            Path3D path = new Path3D(loadedPoints);

            return path;
        }
    }
}
