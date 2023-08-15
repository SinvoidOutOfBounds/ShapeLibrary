namespace ShapeLibrary
{
    public static class ShapeMethods
    {
        /// <summary>
        /// Вычисляет площадь окружности по радиусу
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static double GetArea(double radius)
        {
            return new Circle(radius).Area;
        }
        /// <summary>
        /// Вычисляет площадь треугольника по трём сторонам
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        /// <returns></returns>
        public static double GetArea(double side1, double side2, double side3)
        {
            return new Triangle(side1, side2, side3).Area;
        }
        /// <summary>
        /// Проверяет является ли треугольник прямоугольным по трём сторонам
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        /// <returns></returns>
        public static bool CheckRectangularness(double side1, double side2, double side3)
        {
            return new Triangle(side1, side2, side3).IsRectangular;
        }
    }
}