using Patterns.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Model
{
    public class RealShape : Shape
    {
        public RealShape(string id) : base(id)
        {
        }

        public override double CalculatePerimeter()
        {
            throw new NotImplementedException();
        }

        public override double CalculateSurface()
        {
            throw new NotImplementedException();
        }
    }
    public interface IShapeQuery : IUnitOfWork
    {
    }
    public class ShapeRepository : IRepository<RealShape>, IShapeQuery
    {
        private const string FILE_NAME = "shapes.txt";
        private readonly Dictionary<string, RealShape> _shapes = new();

        public ShapeRepository()
        {
            var folder = AppDomain.CurrentDomain.BaseDirectory;
            var fullPath = System.IO.Path.Combine(folder, FILE_NAME);
            if (File.Exists(fullPath))
            {
                var content = File.ReadAllText(fullPath);
                _shapes = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, RealShape>>(content);
            }
        }
        public void Create(string id)
        {
            var shape = new RealShape(id);
            _shapes.Add(shape.Id, shape);
        }

        public void Delete(string id)
        {
            _shapes.Remove(id);
        }

        public bool Exists(string id)
        {
            return _shapes.ContainsKey(id);
        }

        public RealShape Load(string id)
        {
            if (_shapes.ContainsKey(id))
                return _shapes[id];

            return null;
        }

        public void SaveChanges()
        {
            var folder = AppDomain.CurrentDomain.BaseDirectory;
            var fullPath = System.IO.Path.Combine(folder, FILE_NAME);
            var content = System.Text.Json.JsonSerializer.Serialize(_shapes);
            System.IO.File.WriteAllText(fullPath, content);
        }
    }
}
