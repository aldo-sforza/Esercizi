using Shapes.Model.Repository;

namespace Shapes.Model
{
    namespace Commands
    {
        public record CreateCircle(string id, double radius);
        public record CreateSquare(string id, double edge);
        public record CreateRectangle(string id, double width, double height);
        public record Delete(string id);
    }

    public class ShapeApplicationService
    {
        private readonly IShapeRepository _shapeRepository;

        public ShapeApplicationService(IShapeRepository shapeRepository)
            => _shapeRepository = shapeRepository;

        public void HandleCommand(object command)
        {
            switch (command)
            {
                case Commands.CreateCircle c:
                    _shapeRepository.CreateCircle(c.id, c.radius);                        
                    break;
                case Commands.CreateSquare s:
                    _shapeRepository.CreateSquare(s.id, s.edge);
                    break;
                case Commands.CreateRectangle r:
                    _shapeRepository.CreateRectangle(r.id, r.width, r.height);
                    break;
                case Commands.Delete d:
                    _shapeRepository.Delete(d.id);
                    break;
                default:
                    throw new ArgumentException($"Command {command} is not valid");
            }
        }
    }
}
