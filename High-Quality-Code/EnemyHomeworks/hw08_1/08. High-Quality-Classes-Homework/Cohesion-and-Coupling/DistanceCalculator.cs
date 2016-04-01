using System;

namespace CohesionAndCoupling
{
    public static class DistanceCalculator
    {
        public static double CalculateDistance2D(double x1, double y1, double x2, double y2)
        {
            double deltaX = x2 - x1;
            double deltaY = y2 - y1;

            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            return distance;
        }

        public static double CalculateDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double deltaX = x2 - x1;
            double deltaY = y2 - y1;
            double deltaZ = z2 - z1;

            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);

            return distance;
        }
    }
}
