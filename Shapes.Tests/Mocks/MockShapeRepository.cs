using Moq;
using Shapes.Model;
using Shapes.Model.Repository;

namespace Shapes.Tests.Mocks
{
    internal class MockShapeRepository
        : Mock<IShapeRepository>
    {
        public void GivenIdExist()
            => Setup(shapeRepository => shapeRepository.Exists(It.IsAny<string>())).Returns(true);

        public void GivenIdNotExist()
            => Setup(shapeRepository => shapeRepository.Exists(It.IsAny<string>())).Returns(false);

        public void GivenInvalidCircleParameters()
            => Setup(shapeRepository => shapeRepository.CreateCircle(It.IsAny<string>(), It.IsAny<double>())).Throws(new ArgumentOutOfRangeException());

        public void GivenInvalidSquareParameters()
            => Setup(shapeRepository => shapeRepository.CreateSquare(It.IsAny<string>(), It.IsAny<double>())).Throws(new ArgumentOutOfRangeException());

        public void GivenInvalidRectangleParameters()
            => Setup(shapeRepository => shapeRepository.CreateRectangle(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>())).Throws(new ArgumentOutOfRangeException());

        public void GivenCreateShapeCircleTimes(Times times)
            => Verify(shapeRepository => shapeRepository.CreateCircle(It.IsAny<string>(), It.IsAny<double>()), times);
        public void GivenCreateShapeSquareTimes(Times times)
            => Verify(shapeRepository => shapeRepository.CreateSquare(It.IsAny<string>(), It.IsAny<double>()), times);
        public void GivenCreateShapeRectangleTimes(Times times)
            => Verify(shapeRepository => shapeRepository.CreateRectangle(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>()), times);
        public void GivenExistsCalledTimes(Times times)
                => Verify(shapeRepository => shapeRepository.Exists(It.IsAny<string>()), times);
    }
}
