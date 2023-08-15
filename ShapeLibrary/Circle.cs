namespace ShapeLibrary
{
    public class Circle : Shape
    {
        public double Radius { get; }
        public override double Area
        {
            get
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
        }
        public Circle(double radius)
        {
            if (radius <= 0) throw new ArgumentException("Радиус меньше или равен нулю");
            Radius = radius;
        }
    }
}