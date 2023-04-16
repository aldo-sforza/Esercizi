using Moq;
using Shapes.Model;
using Shapes.Tests.Mocks;
using Shapes.Model.Commands;
using FluentAssertions;

namespace Shapes.Tests
{
    public class ShapeTest
    {
        private readonly MockShapeRepository _shapeRepository = new MockShapeRepository();

        [Fact]
        public void CreateCircleSuccess()
        {
            //Arrange
            var shapeApplicationService = new ShapeApplicationService(_shapeRepository.Object);

            //Act
            shapeApplicationService.HandleCommand(new CreateCircle("123", 3));
            //Assert
            _shapeRepository.GivenCreateShapeCircleTimes(Times.Once());
            _shapeRepository.GivenCreateShapeRectangleTimes(Times.Never());
            _shapeRepository.GivenCreateShapeSquareTimes(Times.Never());
        }
        [Fact]
        public void CreateRectangleSuccess() 
        {
            var shapeAplicationService = new ShapeApplicationService(_shapeRepository.Object);

            shapeAplicationService.HandleCommand(new CreateRectangle("123", 2, 5));
            
            _shapeRepository.GivenCreateShapeRectangleTimes(Times.Once());
            _shapeRepository.GivenCreateShapeCircleTimes(Times.Never());
            _shapeRepository.GivenCreateShapeSquareTimes(Times.Never());
        }

        [Fact]
        public void CreateSquareSuccess()
        {
            var shapeApplicationService = new ShapeApplicationService(_shapeRepository.Object);
            
            shapeApplicationService.HandleCommand(new CreateSquare("123", 3));

            _shapeRepository.GivenCreateShapeSquareTimes(Times.Once());
            _shapeRepository.GivenCreateShapeCircleTimes(Times.Never());
            _shapeRepository.GivenCreateShapeRectangleTimes(Times.Never());

        }
    } 
}