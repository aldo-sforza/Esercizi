namespace Shapes.Model
{
    internal interface IShapeQuery
    {
        public Rectangle GetRectangle(string id);
        public Square GetSquare(string id);
        public Circle GetCircle(string id);
    }
}