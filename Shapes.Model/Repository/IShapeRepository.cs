using Shapes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Model.Repository
{
    public interface IShapeRepository
    {
        void CreateSquare(string id, double edge);
        void CreateRectangle(string id, double width, double height);
        void CreateCircle(string id, double radius);

        Shape Load(string id);

        void Delete(string id);

        bool Exists(string id);
    }
}
