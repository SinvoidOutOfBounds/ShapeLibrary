namespace ShapeLibrary
{
    public class Triangle : Shape
    {
        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }
        public override double Area
        {
            get
            {
                var perimeter = Side1 + Side2 + Side3;
                var halfPerimeter = perimeter / 2;
                return Math.Sqrt(halfPerimeter * (halfPerimeter - Side1) * (halfPerimeter - Side2) * (halfPerimeter - Side3));
            }
        }
        public bool IsRectangular
        {
            get
            {
                return Math.Pow(Side1, 2) + Math.Pow(Side2, 2) == Math.Pow(Side3, 2)
                    || Math.Pow(Side1, 2) + Math.Pow(Side3, 2) == Math.Pow(Side2, 2)
                    || Math.Pow(Side2, 2) + Math.Pow(Side3, 2) == Math.Pow(Side1, 2);
            }
        }
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0) throw new ArgumentException("Сторона меньше или равна нулю");
            if (a + b < c || b + c < a || a + c < b) throw new ArgumentException("Треугольник с такими сторонами не существует");
            Side1 = a;
            Side2 = b;
            Side3 = c;
        }
    }
}