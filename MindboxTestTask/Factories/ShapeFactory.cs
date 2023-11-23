using MindboxTestTask.Interfaces;
using MindboxTestTask.Models;
using System.Globalization;

namespace MindboxTestTask.Factories
{
    public class ShapeFactory : IShapeFactory
    {
        public Shape CreateShape(string type, params string[] parameters)
        {
            switch (type.ToLower())
            {
                case "circle":
                    if (parameters.Length != 1) throw new ArgumentException("Invalid number of parameters for circle");
                    if (double.TryParse(parameters[0], NumberStyles.Any, CultureInfo.InvariantCulture, out double radius))
                    {
                        return new Circle { Radius = radius };
                    }
                    else
                    {
                        throw new ArgumentException("Invalid radius");
                    }
                case "triangle":
                    if (parameters.Length != 3) throw new ArgumentException("Invalid number of parameters for triangle");
                    if (double.TryParse(parameters[0], NumberStyles.Any, CultureInfo.InvariantCulture, out double sideA) &&
                        double.TryParse(parameters[1], NumberStyles.Any, CultureInfo.InvariantCulture, out double sideB) &&
                        double.TryParse(parameters[2], NumberStyles.Any, CultureInfo.InvariantCulture, out double sideC))
                    {
                        return new Triangle { SideA = sideA, SideB = sideB, SideC = sideC };
                    }
                    else
                    {
                        throw new ArgumentException("Invalid sides");
                    }
                case "square":
                    if (parameters.Length != 1) throw new ArgumentException("Invalid number of parameters for square");
                    if (double.TryParse(parameters[0], NumberStyles.Any, CultureInfo.InvariantCulture, out double side))
                    {
                        return new Square { Side = side };
                    }
                    else
                    {
                        throw new ArgumentException("Invalid side");
                    }
                case "rectangle":
                    if (parameters.Length != 2) throw new ArgumentException("Invalid number of parameters for rectangle");
                    if (double.TryParse(parameters[0], NumberStyles.Any, CultureInfo.InvariantCulture, out double length) &&
                        double.TryParse(parameters[1], NumberStyles.Any, CultureInfo.InvariantCulture, out double width))
                    {
                        return new Models.Rectangle { Length = length, Width = width };
                    }
                    else
                    {
                        throw new ArgumentException("Invalid length or width");
                    }
                default:
                    throw new ArgumentException("Invalid shape type");

            }
        }
    }
}