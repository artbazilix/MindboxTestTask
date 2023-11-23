namespace MindboxTestTask.Models
{
    public class Square : Shape
    {
        public double Side { get; set; }

        public override double GetArea()
        {
            return Math.Pow(Side, 2);
        }
    }
}
