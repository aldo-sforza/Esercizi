using Shapes.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Model
{
    public class ShapeRepository : IShapeRepository<Shape>
    {
        private const string FILE_NAME = "shapes.txt";
        private readonly Dictionary<string, Shape> _shapes = new();

        public void CreateCircle(double radius)
        {
            Shape circle = new Circle(radius);
            _shapes.Add(circle.Id, circle);
        }

        public void CreateRectangle(double width, double height)
        {
            Shape rectangle = new Rectangle(width, height);
            _shapes.Add(rectangle.Id, rectangle);
        }

        public void CreateSquare(double edge)
        {
            Shape square = new Square(edge);
            _shapes.Add(square.Id, square);
        }

        public void Delete(string id)
        {
            _shapes.Remove(id);
        }

        public bool Exists(string id)
        {
            return _shapes.ContainsKey(id);
        }

        public Shape Load(string id)
        {
            return _shapes[id];
        }
    }
}
