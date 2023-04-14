using Patterns.Repository;
using Shapes.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Model
{
    public class ShapeRepository
        : IShapeRepository<Shape>, IShapeQuery<Shape>
    {
        private readonly Dictionary<string, Shape> _shapes = new();

        public void CreateCircle(string name, double radius)
        {
            var circle = new Circle(radius);
            _shapes.Add(name, circle);
        }

        public void CreateRectangle(string name, double width, double height)
        {
            var rectangle = new Rectangle(width, height);
            _shapes.Add(name, rectangle);
        }

        public void CreateSquare(string name, double edge)
        {
            var square = new Square(edge);
            _shapes.Add(name, square);
        }

        public void Delete(string name) => _shapes.Remove(name);

        public bool Exists(string name) => _shapes.ContainsKey(name);

        public IEnumerable<Circle> GetCircle(string name) => _shapes.Values.OfType<Circle>(); //copiato dal prof

        public IEnumerable<Rectangle> GetRectangles(string name) => _shapes.Values.OfType<Rectangle>(); //copiato dal prof

        public IEnumerable<Square> GetSquare(string name) => _shapes.Values.OfType<Square>(); //copiato dal prof

        public Shape Load(string name)
        {
            if (_shapes.ContainsKey(name)) return _shapes[name];
            return null;
        }

    }
}
