using System;

namespace CohesionAndCoupling
{
    public class UtilsExamples
    {
        public static void Main()
        {
            Console.WriteLine(FileExtensionsUtil.GetFileExtension("example"));
            Console.WriteLine(FileExtensionsUtil.GetFileExtension("example.pdf"));
            Console.WriteLine(FileExtensionsUtil.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileExtensionsUtil.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileExtensionsUtil.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileExtensionsUtil.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", DistanceCalculator.CalculateDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", DistanceCalculator.CalculateDistance3D(5, 2, -1, 3, -6, 4));

            CuboidFigure cuboidFigure = new CuboidFigure(3, 4, 5);
            Console.WriteLine("Volume = {0:f2}", cuboidFigure.CalculateVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", cuboidFigure.CalculateDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", cuboidFigure.CalculateDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", cuboidFigure.CalculateDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", cuboidFigure.CalculateDiagonalYZ());
        }
    }
}
