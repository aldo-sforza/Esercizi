using Patterns.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Model
{
    namespace Commands
    {
        public record CreateCircle(string id, double radius);
        public record CreateSquare(string id, double edge);
        public record CreateRectangle(string id, double width, double height);
    }
    public class ShapeRepository : IShapeRepository
    {
        private readonly Dictionary<string, Shape> _shapes = new();

        public void Create(object command)
        {
            switch(command)
            {
                case Commands.CreateCircle c:
                    _shapes.Add(c.id, new Circle(c.id,c.radius));
                    break;
                case Commands.CreateSquare s:
                    _shapes.Add(s.id, new Square(s.id,s.edge));
                    break;
                case Commands.CreateRectangle r:
                    _shapes.Add(r.id, new Rectangle(r.id,r.width,r.height));
                    break;
                default: throw new ArgumentException("Create Shape Command used not found");
            }
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public bool Exists(string id)
        {
            throw new NotImplementedException();
        }

        public Shape Load(string id)
        {
            throw new NotImplementedException();
        }
    }
}
