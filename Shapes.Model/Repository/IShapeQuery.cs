using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Model.Repository
{
    public interface IShapeQuery<T> where T : Shape
    {
        IEnumerable<Circle> GetCircles(string name);
        IEnumerable<Square> GetSquares(string name);
        IEnumerable<Rectangle> GetRectangles(string name);
    }
}
