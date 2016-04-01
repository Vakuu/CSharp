using System;

namespace CohesionAndCoupling
{
    public class CuboidFigure
    {
        private double width;
        private double height;
        private double depth;

        public CuboidFigure(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Width cannot be negative number or zero.");
                }

                this.width = value;
            }
        }

        public double Height 
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Height cannot be negative number or zero.");
                }

                this.height = value;
            }
        }

        public double Depth 
        {
             get
            {
                return this.depth;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Depth cannot be negative number or zero.");
                }

                this.depth = value;
            }
        }

        public double CalculateVolume()
        {
            double volume = this.Width * this.Height * this.Depth;

            return volume;
        }

        public double CalculateDiagonalXYZ()
        {
            double distance = DistanceCalculator.CalculateDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);

            return distance;
        }

        public double CalculateDiagonalXY()
        {
            double distance = DistanceCalculator.CalculateDistance2D(0, 0, this.Width, this.Height);

            return distance;
        }

        public double CalculateDiagonalXZ()
        {
            double distance = DistanceCalculator.CalculateDistance2D(0, 0, this.Width, this.Depth);

            return distance;
        }

        public double CalculateDiagonalYZ()
        {
            double distance = DistanceCalculator.CalculateDistance2D(0, 0, this.Height, this.Depth);

            return distance;
        }
    }
}
