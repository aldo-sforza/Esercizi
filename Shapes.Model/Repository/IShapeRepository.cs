using Shapes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repository
{
    public interface IShapeRepository
    {
        void Create(object command);

        Shape Load(string id);

        void Delete(string id);

        bool Exists(string id);
    }
}
