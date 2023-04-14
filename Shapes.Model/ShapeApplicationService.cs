using Patterns.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Model
{
    public class ShapeApplicationService
    {
        private readonly IShapeRepository _shapeRepository;

        public ShapeApplicationService(IShapeRepository shapeRepository)
        {
            _shapeRepository = shapeRepository;
        }

        public void HandleCreate(string id)
        {
            
        }
    }
}
