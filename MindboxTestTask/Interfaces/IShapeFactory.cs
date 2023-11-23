namespace MindboxTestTask.Interfaces
{
    public interface IShapeFactory
    {
        Shape CreateShape(string type, params string[] parameters);
    }
}
