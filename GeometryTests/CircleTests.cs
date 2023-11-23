using MindboxTestTask.Models;

namespace GeometryTests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void GetArea_ReturnsCorrectArea()
        {
            var circle = new Circle { Radius = 2 };
            var expectedArea = Math.PI * 4;
            Assert.AreEqual(expectedArea, circle.GetArea());
        }

        [Test]
        public void Circle_GetArea_ThrowsExceptionWhenRadiusIsNegative()
        {
            var circle = new Circle { Radius = -1 };
            Assert.Throws<ArgumentException>(() => circle.GetArea());
        }

        [Test]
        public void Circle_GetArea_ReturnsCorrectAreaForRandomRadius()
        {
            var random = new Random();
            for (int i = 0; i < 100; i++)
            {
                var radius = random.NextDouble() * 100;
                var circle = new Circle { Radius = radius };
                var expectedArea = Math.PI * Math.Pow(radius, 2);
                Assert.AreEqual(expectedArea, circle.GetArea(), 1e-10);
            }
        }

        [Test]
        public void Circle_GetArea_ReturnsZeroWhenRadiusIsZero()
        {
            var circle = new Circle { Radius = 0 };
            Assert.AreEqual(0, circle.GetArea());
        }

        [Test]
        public void Circle_GetArea_ReturnsInfinityWhenRadiusIsVeryLarge()
        {
            var circle = new Circle { Radius = double.MaxValue };
            Assert.AreEqual(double.PositiveInfinity, circle.GetArea());
        }

        [Test]
        public void GetArea_ReturnsForCorrectDouble()
        {
            var circle = new Circle { Radius = 1.5 };
            var expectedArea = Math.PI * Math.Pow(1.5, 2);
            Assert.AreEqual(expectedArea, circle.GetArea());
        }
    }
}
