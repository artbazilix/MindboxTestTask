using System.Globalization;

namespace MindboxTestTask.ViewModels
{
    public class CircleViewModel
    {
        public string Radius { get; set; }

        public double GetArea()
        {
            if (double.TryParse(Radius, NumberStyles.Any, CultureInfo.InvariantCulture, out double radius))
            {
                return Math.PI * Math.Pow(radius, 2);
            }
            else
            {
                throw new ArgumentException("Invalid radius");
            }
        }
    }
}
