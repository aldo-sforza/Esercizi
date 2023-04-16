using Shapes.Model;

namespace Console.Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Playing with shapes");
            var shapeRepository = new ShapeRepository();
            var shapeApplicationService = new ShapeApplicationService(shapeRepository);
        }
    }
}