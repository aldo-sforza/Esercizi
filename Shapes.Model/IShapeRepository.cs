using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Model
{
    internal interface IShapeRepository<T> where T : Shape
    {
        void Create(object command);

        T Load(string id);

        void Delete(string id);

        bool Exists(string id);
    }
}
