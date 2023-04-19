using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Model.Interface
{
    public interface IShapeRepository<T> where T : Shape
    {
        void CreateRectangle(double width, double height);

        void CreateCircle(double radius);

        void CreateSquare(double edge);

        T Load(string id);

        void Delete(string id);

        bool Exists(string id);
    }
}
