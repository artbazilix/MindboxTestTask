using MindboxTestTask.Models;
using System.Drawing;

namespace MindboxTestTask.Interfaces
{
    public interface IShapeFactory
    {
        Shape CreateShape(string type, params double[] parameters);
    }

    public class ShapeFactory : IShapeFactory
    {
        public Shape CreateShape(string type, params double[] parameters)
        {
            switch (type.ToLower())
            {
                case "circle":
                    if (parameters.Length != 1) throw new ArgumentException("Invalid number of parameters for circle");
                    return new Circle { Radius = parameters[0] };
                case "triangle":
                    if (parameters.Length != 3) throw new ArgumentException("Invalid number of parameters for triangle");
                    return new Triangle { SideA = parameters[0], SideB = parameters[1], SideC = parameters[2] };
                case "square":
                    if (parameters.Length != 1) throw new ArgumentException("Invalid number of parameters for square");
                    return new Square { Side = parameters[0] };
                case "rectangle":
                    if (parameters.Length != 2) throw new ArgumentException("Invalid number of parameters for rectangle");
                    return new Models.Rectangle { Length = parameters[0], Width = parameters[1] };
                default:
                    throw new ArgumentException("Invalid shape type");
            }
        }
    }
}
