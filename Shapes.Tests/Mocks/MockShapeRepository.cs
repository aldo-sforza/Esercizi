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

        public void GivenIdCalledTimes(Times times)
            => Verify(shapeRepository => shapeRepository.Exists(It.IsAny<string>()), times);
    }
}
