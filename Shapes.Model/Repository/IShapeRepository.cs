using Patterns.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Model.Repository
{
    public interface IShapeRepository<T> 
        where T : Shape
    {
        void CreateCircle(string name, double radius);
        void CreateSquare(string name, double edge);
        void CreateRectangle(string name, double width, double height);

        T Load(string name);

        void Delete(string name);

        bool Exists(string name);

    }
}
