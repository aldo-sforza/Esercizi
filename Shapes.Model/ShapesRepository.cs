using Patterns.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Model
{
    public class ShapesRepository : IRepository<Shape>, IShapesQuery
    {
        private readonly Dictionary<string, Shape> _shapes = new();
        public ShapesRepository()
        {
            
        }

        public void Create(string id)
        {
            throw new NotImplementedException();
        }
        public void Create(string id, double width, double height)
        {
            if (width.Equals(height))
                _shapes.Add(id, new Square(width, id));
            else
                _shapes.Add(id, new Rectangle(width, height, id));
        }
        public void Create (string id, double radius)
        {
            _shapes.Add(id, new Circle(radius, id));
        }
        public void Delete(string id)
        {
            _shapes.Remove(id);
        }
        public bool Exists(string id)
        {
            return _shapes.ContainsKey(id);
        }

        public Circle GetCircle(string id)
        {
            var filter = new Circle(1, "filter");
            if (!_shapes[id].GetType().Equals(filter.GetType()))
                throw new ArgumentException();
            else
                return (Circle)_shapes[id];
        }

        public Rectangle GetRectangle(string id)
        {
            var filter = new Rectangle(2, 1, "filter");
            if (!_shapes[id].GetType().Equals(filter.GetType()))
                throw new ArgumentException();
            else
                return (Rectangle)_shapes[id];
        }

        public Square GetSquare(string id)
        {
            var filter = new Square(1, "filter");
            if (!_shapes[id].GetType().Equals(filter.GetType()))
                throw new ArgumentException();
            else
                return (Square)_shapes[id];
        }

        public Shape Load(string id)
        {
            if (_shapes.ContainsKey(id))
                return _shapes[id];

            return null;
        }
    }
}
