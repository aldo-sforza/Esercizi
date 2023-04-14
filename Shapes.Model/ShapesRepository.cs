using Patterns.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Model
{
    public class ShapesRepository : IShapesRepository, IRepository<Shape>, IShapesQuery
    {
        private readonly Dictionary<string, Shape> _shapes = new();
        public ShapesRepository() 
        {

        }
        
        //IShapeRepository
        public void CreateRectangle(string id, double width, double height)
            =>_shapes.Add(id, new Rectangle(width, height, id));
        public void CreateSquare(string id, double edge)
            =>_shapes.Add(id, new Square(edge, id));
        public void CreateCircle(string id, double radius)
            =>_shapes.Add(id, new Square(radius, id));

        
        //IRepository
        public void Create(string id)
        {
            throw new NotImplementedException();
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
            if (_shapes.ContainsKey(id))
                return _shapes[id];

            return null;
        }

        //IShapesQuery
        public bool TryGetCircle(string id, out Circle circle)
        {
            circle = null;
            if (!_shapes[id].GetType().Equals(typeof(Circle)))
            {
                circle = (Circle)_shapes[id];
                return true; 
            }
            return false;
        }
        public IEnumerable<Circle> GetCircles()
        {
            return _shapes.Values.OfType<Circle>();
        }
        public bool TryGetRectangle(string id, out Rectangle rectangle)
        {
            rectangle = null;
            if (!_shapes[id].GetType().Equals(typeof(Circle)))
            {
                rectangle = (Rectangle)_shapes[id];
                return true;
            }
            return false;
        }
        public IEnumerable<Rectangle> GetRectangles()
        {
            return _shapes.Values.OfType<Rectangle>();
        }
        public bool TryGetSquare(string id, out Square square)
        {
            square = null;
            if (!_shapes[id].GetType().Equals(typeof(Circle)))
            {
                square = (Square)_shapes[id];
                return true;
            }
            return false;
        }
        public IEnumerable<Square> GetSquares()
        {
            return _shapes.Values.OfType<Square>();
        }
    }
}
