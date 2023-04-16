using Shapes.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Model
{
    namespace Commands
    {

    }
    public class ShapeRepository : IShapeRepository
    {
        private readonly Dictionary<string, Shape> _shapes = new();

        public void CreateCircle(string id, double radius)
        {
            if(Exists(id))
                _shapes.Add(id, new Circle(id, radius));
        }
            

        public void CreateRectangle(string id, double width, double height)
        {
            if (Exists(id))
                _shapes.Add(id, new Rectangle(id, width, height));
        }

        public void CreateSquare(string id, double edge)
        {
            if (Exists(id))
                _shapes.Add(id, new Square(id, edge));
        }

        public void Delete(string id)
        {
            if(Exists(id))
                _shapes.Remove(id);
        }

        public bool Exists(string id)
        {
            if (_shapes.ContainsKey(id))
                return true;
            throw new ArgumentException($"id: {id} already exists");
        } 

        public Shape Load(string id)
        {
            if(Exists(id))
                return _shapes[id];
            return null;
        }

    }
}
