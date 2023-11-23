using MindboxTestTask.Models;

namespace GeometryTests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void GetArea_ReturnsCorrectArea()
        {
            var triangle = new Triangle { SideA = 3, SideB = 4, SideC = 5 };
            var expectedArea = 6; // Площадь прямоугольного треугольника равна 1/2 * a * b
            Assert.AreEqual(expectedArea, triangle.GetArea());
        }

        [Test]
        public void IsRightTriangle_ReturnsTrueForRightTriangle()
        {
            var triangle = new Triangle { SideA = 3, SideB = 4, SideC = 5 };
            Assert.IsTrue(triangle.IsRightTriangle());
        }

        [Test]
        public void IsRightTriangle_ReturnsFalseForNonRightTriangle()
        {
            var triangle = new Triangle { SideA = 3, SideB = 4, SideC = 6 };
            Assert.IsFalse(triangle.IsRightTriangle());
        }

        [Test]
        public void Triangle_GetArea_ThrowsExceptionWhenSideIsNegative()
        {
            var triangle = new Triangle { SideA = -3, SideB = 4, SideC = 5 };
            Assert.Throws<ArgumentException>(() => triangle.GetArea());
        }

        [Test]
        public void GetArea_ReturnsCorrectAreaForRandomSides()
        {
            var random = new Random();
            for (int i = 0; i < 100; i++)
            {
                var sideA = random.NextDouble() * 100; // Случайная сторона от 0 до 100
                var sideB = random.NextDouble() * 100; // Случайная сторона от 0 до 100
                var sideC = random.NextDouble() * 100; // Случайная сторона от 0 до 100
                var triangle = new Triangle { SideA = sideA, SideB = sideB, SideC = sideC };
                var s = (sideA + sideB + sideC) / 2;
                var expectedArea = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
                Assert.AreEqual(expectedArea, triangle.GetArea(), 1e-10); // Допускаем небольшую погрешность
            }
        }

        [Test]
        public void GetArea_ThrowsExceptionWhenAnySideIsZero()
        {
            var triangle = new Triangle { SideA = 0, SideB = 4, SideC = 5 };
            Assert.Throws<ArgumentException>(() => triangle.GetArea());
        }

        [Test]
        public void GetArea_ReturnsInfinityWhenAnySideIsVeryLarge()
        {
            var triangle = new Triangle { SideA = double.MaxValue, SideB = 4, SideC = 5 };
            Assert.AreEqual(double.PositiveInfinity, triangle.GetArea());
        }
    }
}
