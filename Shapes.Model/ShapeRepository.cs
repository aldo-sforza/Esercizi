using Patterns.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Model
{

    public interface IShapeQuery
    {
        IEnumerable<Circle> GetCircles();
        IEnumerable<Square> GetSquares();
        IEnumerable<Rectangle> GetRectangles();
    }


    public interface IShapeRepository<T> where T: Shape
    {
        void Add(T item);
        void Update(T item);
        void Delete(T item);
        T Load<T>(string id);

        IEnumerable<Shape> Shapes { get; }
    
    }
    public  class ShapeRepository : IShapeRepository<Shape>, IShapeQuery
    {
        private readonly Dictionary<string, Shape> _shapes = new Dictionary<string, Shape>();
        public IEnumerable<Shape> Shapes => _shapes.Values;

        public void Add(Shape item)
        {
            _shapes.Add(item.Id,item);
        }

        public void Delete(Shape item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Circle> GetCircles()
        {
           return _shapes.Values.OfType<Circle>();
        }

        public IEnumerable<Rectangle> GetRectangles()
        {
            return _shapes.Values.OfType<Rectangle>();
        }

        public IEnumerable<Square> GetSquares()
        {
            return _shapes.Values.OfType<Square>();
        }

        public T Load<T>(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(Shape item)
        {
            throw new NotImplementedException();
        }
    }
}
