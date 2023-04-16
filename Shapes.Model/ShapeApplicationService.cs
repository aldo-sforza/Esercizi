using Shapes.Model.Repository;

namespace Shapes.Model
{
    namespace Commands
    {
        public record CreateCircle(string id, double radius);
        public record CreateSquare(string id, double edge);
        public record CreateRectangle(string id, double width, double height);
    }

    public class ShapeApplicationService
    {
        private readonly IShapeRepository _shapeRepository;

        public ShapeApplicationService(IShapeRepository shapeRepository)
            => _shapeRepository = shapeRepository;

        public void HandleCreate(object command)
        {
            switch (command)
            {
                case Commands.CreateCircle c:
                    if(!_shapeRepository.Exists(c.id))
                        _shapeRepository.CreateCircle(c.id, c.radius);
                    else
                        throw new ArgumentException($"id {c.id} Exist");
                    break;
                case Commands.CreateSquare s:
                    if(!_shapeRepository.Exists(s.id))
                        _shapeRepository.CreateSquare(s.id, s.edge);
                    else
                        throw new ArgumentException($"id {s.id} Exist");
                    break;
                case Commands.CreateRectangle r:
                    if(!_shapeRepository.Exists(r.id))
                        _shapeRepository.CreateRectangle(r.id, r.width, r.height);
                    else
                        throw new ArgumentException($"id {r.id} Exist");
                    break;
                default:
                    throw new ArgumentException($"Command {command} is not valid");
            }
        }
    }
}
