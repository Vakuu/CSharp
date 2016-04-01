namespace _01.Shapes
{
    class Rhombus : BasicShape
    {
        public Rhombus(double width, double height) : base(width, height)
        {

        }
        public override double CalculateArea()
        {
            return this.Height * this.Width;
        }
        public override double CalculatePerimeter()
        {
            return 4 * this.Width;
        }
    }
}
