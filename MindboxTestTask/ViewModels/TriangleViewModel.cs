using System.Globalization;

namespace MindboxTestTask.ViewModels
{
    public class TriangleViewModel
    {
        public string SideA { get; set; }
        public string SideB { get; set; }
        public string SideC { get; set; }

        public double GetArea()
        {
            if (double.TryParse(SideA, NumberStyles.Any, CultureInfo.InvariantCulture, out double sideA) &&
                double.TryParse(SideB, NumberStyles.Any, CultureInfo.InvariantCulture, out double sideB) &&
                double.TryParse(SideC, NumberStyles.Any, CultureInfo.InvariantCulture, out double sideC))
            {
                var p = (sideA + sideB + sideC) / 2;
                return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            }
            else
            {
                throw new ArgumentException("Invalid sides");
            }
        }

        public bool IsRightTriangle()
        {
            if (double.TryParse(SideA, NumberStyles.Any, CultureInfo.InvariantCulture, out double sideA) &&
                double.TryParse(SideB, NumberStyles.Any, CultureInfo.InvariantCulture, out double sideB) &&
                double.TryParse(SideC, NumberStyles.Any, CultureInfo.InvariantCulture, out double sideC))
            {
                var sides = new[] { sideA, sideB, sideC };
                Array.Sort(sides);
                return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < 0.000001;
            }
            else
            {
                throw new ArgumentException("Invalid sides");
            }
        }
    }
}
