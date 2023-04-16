using Moq;
using Shapes.Model;
using Shapes.Tests.Mocks;
using Shapes.Model.Commands;

namespace Shapes.Tests
{
    public class ShapeTest
    {
        private readonly MockShapeRepository _shapeRepository = new MockShapeRepository();
        [Fact]
        public void HandleCreateCircleSuccess()
        {
            //Arrange
            _shapeRepository.GivenIdNotExist();
            
            var shapeApplicationService = 
                new ShapeApplicationService(_shapeRepository.Object);

            //Act
            shapeApplicationService.HandleCreate(new CreateCircle("123", 3));

            //Assert
            _shapeRepository.GivenIdCalledTimes(Times.Once());
        }
    }
}