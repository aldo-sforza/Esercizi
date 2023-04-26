namespace Shapes.Model
{
    public interface IShapesQuery
    {
        public bool TryGetRectangle(string id, out Rectangle rectangle);
        public bool TryGetSquare(string id, out Square square);
        public bool TryGetCircle(string id, out Circle circle);
        public IEnumerable<Rectangle> GetRectangles();
        public IEnumerable<Square> GetSquares();
        public IEnumerable<Circle> GetCircles(); 
    }
}