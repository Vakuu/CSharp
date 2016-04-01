using System;
using System.Collections.Generic;
using Geometry.Geometry3D;
using Geometry.Geometry.Storage;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D firstPoint = new Point3D(2, 3.4, 8);
            Point3D secondPoint = new Point3D(4.4, 25, 1);
            Point3D thirdPoint = new Point3D(3.3, 3.4, 5.5);

            double distanceBetweenTwoPoints = DistanceCalculator3D.CalculateDistanceIn3D(firstPoint, secondPoint);

            Console.WriteLine("The distance between the points in Euclid 3d space is : " + distanceBetweenTwoPoints);

            List<Point3D> pointsList = new List<Point3D>();

            pointsList.Add(firstPoint);
            pointsList.Add(secondPoint);
            pointsList.Add(thirdPoint);

            Path3D pathToSave = new Path3D(pointsList);

            string operationResult = Storage.Save3dPoints(pathToSave);

            Console.WriteLine(operationResult);

            Path3D pathToLoad = Storage.Load3dPoints();

            List<Point3D> loadedPoints = new List<Point3D>();

            loadedPoints = pathToLoad.SequenceOfPoints;

            foreach (Point3D currentPoint in loadedPoints)
            {
                Console.WriteLine(currentPoint);
            }
        }
    }
}
