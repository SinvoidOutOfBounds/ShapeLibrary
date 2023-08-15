namespace ShapeLibrary.Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(3, 9 * Math.PI)]
        [TestCase(2.5, 6.25 * Math.PI)]
        public void TestValidCircle(double a, double expectedResult)
        {
            Assert.That(ShapeMethods.GetArea(a), Is.EqualTo(expectedResult));
        }
        [TestCase(0)]
        [TestCase(-2.5)]
        public void TestInvalidCircle(double a)
        {
            Assert.Throws<ArgumentException>(() => ShapeMethods.GetArea(a));
        }
        [TestCase(3, 4, 5, 6)]
        [TestCase(11, 13, 20, 66)]
        public void TestValidTriangle(double a, double b, double c, double expectedResult)
        {
            Assert.That(ShapeMethods.GetArea(a, b, c), Is.EqualTo(expectedResult));
        }
        [TestCase(-3, 4, 5)]
        [TestCase(1, 1, 3)]
        public void TestInvalidTriangle(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => ShapeMethods.GetArea(a, b, c));
        }
        [TestCase(3, 4, 5, true)]
        [TestCase(11, 13, 20, false)]
        public void TestTriangleRectangularness(double a, double b, double c, bool expectedResult)
        {
            Assert.That(ShapeMethods.CheckRectangularness(a, b, c), Is.EqualTo(expectedResult));
        }
    }
}