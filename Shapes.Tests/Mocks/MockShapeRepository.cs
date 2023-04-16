using Moq;
using Shapes.Model;
using Shapes.Model.Repository;

namespace Shapes.Tests.Mocks
{
    internal class MockShapeRepository
        : Mock<IShapeRepository>
    {
        public void GivenIdExist()
        {
            Setup(shaperepository => shaperepository.Exists(It.IsAny<string>()))
                .Returns(true);
        }
        public void GivenIdNotExist()
        {
            Setup(shaperepository => shaperepository.Exists(It.IsAny<string>()))
                .Returns(false);
        }

        public void GivenCreateShapeCircleTimes(Times times)
            => Verify(shapeRepository => shapeRepository.CreateCircle(It.IsAny<string>(), It.IsAny<double>()), times);
        public void GivenCreateShapeSquareTimes(Times times)
            => Verify(shapeRepository => shapeRepository.CreateSquare(It.IsAny<string>(), It.IsAny<double>()), times);
        public void GivenCreateShapeRectangleTimes(Times times)
            => Verify(shapeRepository => shapeRepository.CreateRectangle(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>()), times);
        public void GivenIdCalledTimes(Times times)
                => Verify(shapeRepository => shapeRepository.Exists(It.IsAny<string>()), times);
    }
}
