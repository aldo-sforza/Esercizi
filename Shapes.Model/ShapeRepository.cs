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
            => _shapes.Add(id, new Circle(id, radius));

        public void CreateRectangle(string id, double width, double height)
            => _shapes.Add(id, new Rectangle(id, width, height));
        public void CreateSquare(string id, double edge)
            => _shapes.Add(id, new Square(id, edge));

        public void Delete(string id)
            => throw new NotImplementedException();

        public bool Exists(string id)
            => _shapes.ContainsKey(id);

        public Shape Load(string id)
           => throw new NotImplementedException();

    }
}
