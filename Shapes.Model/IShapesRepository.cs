namespace Shapes.Model
{
    public interface IShapesRepository
    {
        public void CreateSquare(string id, double edge);
        public void CreateRectangle(string id, double width, double height);
        public void CreateCircle(string id, double radius);
    }
}