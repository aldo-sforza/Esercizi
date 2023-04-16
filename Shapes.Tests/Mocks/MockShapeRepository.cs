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
            Setup(shapeRepository => shapeRepository.CreateCircle(It.IsAny<string>(), It.IsAny<double>()))
                .Throws(new ArgumentException("id: {} already exists"));
            Setup(shapeRepository => shapeRepository.CreateRectangle(It.IsAny<string>(), It.IsAny<double>(),It.IsAny<double>()))
                .Throws(new ArgumentException("id: {} already exists"));
            Setup(shapeRepository => shapeRepository.CreateSquare(It.IsAny<string>(), It.IsAny<double>()))
                .Throws(new ArgumentException("id: {} already exists"));
        }
        public void GivenInvalidParameters()
        {
            Setup(shapeRepository => shapeRepository.CreateCircle(It.IsAny<string>(), It.IsAny<double>()))
                .Throws(new ArgumentOutOfRangeException());
            Setup(shapeRepository => shapeRepository.CreateRectangle(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>()))
                .Throws(new ArgumentOutOfRangeException());
            Setup(shapeRepository => shapeRepository.CreateSquare(It.IsAny<string>(), It.IsAny<double>()))
                .Throws(new ArgumentOutOfRangeException());
        }


        public void GivenCreateShapeCircleTimes(Times times)
            => Verify(shapeRepository => shapeRepository.CreateCircle(It.IsAny<string>(), It.IsAny<double>()), times);
        public void GivenCreateShapeSquareTimes(Times times)
            => Verify(shapeRepository => shapeRepository.CreateSquare(It.IsAny<string>(), It.IsAny<double>()), times);
        public void GivenCreateShapeRectangleTimes(Times times)
            => Verify(shapeRepository => shapeRepository.CreateRectangle(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>()), times);
        
    }
}
