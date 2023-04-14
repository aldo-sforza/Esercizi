namespace Shapes.Model
{
    internal interface IShapesQuery
    {
        public Rectangle GetRectangle(string id);
        public Square GetSquare(string id);
        public Circle GetCircle(string id);
    }
}