using System;

namespace Abstraction
{
    class Rectangle : IRectancle
    {

        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
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
                    throw new ArgumentException("Width of rectangle cannot be negative or zero");
                }

                this.width = value;
            }
        }

      public double Height {
          get { return this.height; }
          set
          {
              if (value <= 0)
              {
                  throw new ArgumentException("Heigth of Rectangle cannot be zero or negative.");
              }

              this.height = value;
          }
      }

        public double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);

            return perimeter;
        }

        public double CalcSurface()
        {
            double surface = this.Width * this.Height;

            return surface;
        }
    }
}
