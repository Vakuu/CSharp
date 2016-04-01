using System;

namespace Abstraction
{
    public abstract class Figure : IFigure
    {
        private double width;
        private double height;
        private double radius;

        protected Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        protected Figure(double radius)
        {
            this.Radius = radius;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Figure width cannot be empty.", "width");
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
                if (value < 0)
                {
                    throw new ArgumentNullException("Fidure height cannot be empty.", "height");
                }

                this.height = value;
            }
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Radius cannot be empty.", "radius");
                }

                this.radius = value;
            }
        }

        public abstract double CalcPerimeter();

        public abstract double CalcSurface();
     }
}