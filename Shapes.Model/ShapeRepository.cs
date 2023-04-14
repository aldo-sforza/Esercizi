using Patterns.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Model
{
    namespace Command
    {
        public record CreateCircle (string id, double radius);
        public record CreateRectangle(string id, double width, double height);
        public record CreateSquare(string id, double edge);
    }
    internal class ShapeRepository : IShapeRepository<Shape>
    {
        private Shape shape {  get; set; }

        private readonly Dictionary<string, Shape> _shape = new();
        public void Create(object command)
        {
            switch (command)
            {
                case Command.CreateCircle c:
                    shape = new Circle(c.id, c.radius);
                    _shape.Add(shape.Id, shape);
                    break;
                case Command.CreateRectangle c:
                    shape = new Rectangle(c.id, c.width, c.height);
                    break;
                case Command.CreateSquare c:
                    shape = new Square(c.id, c.edge);
                    break;
            }
        }

        public void Delete(string id)
        {
            if(shape != null)
            {
                
            }
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
