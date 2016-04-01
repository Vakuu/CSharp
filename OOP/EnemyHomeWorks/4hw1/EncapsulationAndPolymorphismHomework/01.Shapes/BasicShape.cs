namespace _01.Shapes
{
    abstract class BasicShape : IShape
    {
        public BasicShape(double width, double height)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Width { get; set; }
        public double Height { get; set; }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}
