using MindboxTestTask.Models;

namespace GeometryTests
{
    [TestFixture]
    public class RectangleTests
    {
        [Test]
        public void GetArea_ReturnsCorrectArea()
        {
            var rectangle = new Rectangle { Length = 3, Width = 4 };
            var expectedArea = 12;
            Assert.AreEqual(expectedArea, rectangle.GetArea());
        }

        [Test]
        public void Rectangle_GetArea_ThrowsExceptionWhenLengthOrWidthIsNegative()
        {
            var rectangle = new Rectangle { Length = -3, Width = 4 };
            Assert.Throws<ArgumentException>(() => rectangle.GetArea());
        }

        [Test]
        public void GetArea_ReturnsCorrectAreaForRandomLengthAndWidth()
        {
            var random = new Random();
            for (int i = 0; i < 100; i++)
            {
                var length = random.NextDouble() * 100;
                var width = random.NextDouble() * 100;
                var rectangle = new Rectangle { Length = length, Width = width };
                var expectedArea = length * width;
                Assert.AreEqual(expectedArea, rectangle.GetArea(), 1e-10);
            }
        }

        [Test]
        public void GetArea_ThrowsExceptionWhenLengthOrWidthIsZero()
        {
            var rectangle = new Rectangle { Length = 0, Width = 4 };
            Assert.Throws<ArgumentException>(() => rectangle.GetArea());
        }

        [Test]
        public void GetArea_ReturnsInfinityWhenLengthOrWidthIsVeryLarge()
        {
            var rectangle = new Rectangle { Length = double.MaxValue, Width = 4 };
            Assert.AreEqual(double.PositiveInfinity, rectangle.GetArea());
        }

        [Test]
        public void GetArea_ReturnsForCorrectDouble()
        {
            var rectangle = new Rectangle { Length = 3.5, Width = 4.5 };
            var expectedArea = 3.5 * 4.5;
            Assert.AreEqual(expectedArea, rectangle.GetArea());
        }
    }
}
