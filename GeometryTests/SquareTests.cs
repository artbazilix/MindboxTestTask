using MindboxTestTask.Models;

namespace GeometryTests
{
    [TestFixture]
    public class SquareTests
    {
        [Test]
        public void GetArea_ReturnsCorrectArea()
        {
            var square = new Square { Side = 2 };
            var expectedArea = 4; // Площадь квадрата равна a^2
            Assert.AreEqual(expectedArea, square.GetArea());
        }

        [Test]
        public void Square_GetArea_ThrowsExceptionWhenSideIsNegative()
        {
            var square = new Square { Side = -2 };
            Assert.Throws<ArgumentException>(() => square.GetArea());
        }

        [Test]
        public void GetArea_ReturnsCorrectAreaForRandomSide()
        {
            var random = new Random();
            for (int i = 0; i < 100; i++)
            {
                var side = random.NextDouble() * 100; // Случайная сторона от 0 до 100
                var square = new Square { Side = side };
                var expectedArea = Math.Pow(side, 2);
                Assert.AreEqual(expectedArea, square.GetArea(), 1e-10); // Допускаем небольшую погрешность
            }
        }

        [Test]
        public void GetArea_ThrowsExceptionWhenSideIsZero()
        {
            var square = new Square { Side = 0 };
            Assert.Throws<ArgumentException>(() => square.GetArea());
        }

        [Test]
        public void GetArea_ReturnsInfinityWhenSideIsVeryLarge()
        {
            var square = new Square { Side = double.MaxValue };
            Assert.AreEqual(double.PositiveInfinity, square.GetArea());
        }
    }
}
