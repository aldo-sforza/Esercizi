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
            _shapeRepository.GivenCreateShapeCircleTimes(Times.Once());
            _shapeRepository.GivenCreateShapeRectangleTimes(Times.Never());
            _shapeRepository.GivenCreateShapeSquareTimes(Times.Never());
        }

        [Fact]
        public void HandleCreateSquareSuccess()
        {
            //Arrange
            _shapeRepository.GivenIdNotExist();

            var shapeApplicationService =
                new ShapeApplicationService(_shapeRepository.Object);

            //Act
            shapeApplicationService.HandleCreate(new CreateSquare("123", 3));

            //Assert
            _shapeRepository.GivenIdCalledTimes(Times.Once());
            _shapeRepository.GivenCreateShapeSquareTimes(Times.Once());
            _shapeRepository.GivenCreateShapeCircleTimes(Times.Never());
            _shapeRepository.GivenCreateShapeRectangleTimes(Times.Never());
        }

        [Fact]
        public void HandleCreateRectangleSuccess()
        {
            //Arrange
            _shapeRepository.GivenIdNotExist();

            var shapeApplicationService =
                new ShapeApplicationService(_shapeRepository.Object);

            //Act
            shapeApplicationService.HandleCreate(new CreateRectangle("123", 3,5));

            //Assert
            _shapeRepository.GivenIdCalledTimes(Times.Once());
            _shapeRepository.GivenCreateShapeRectangleTimes(Times.Once());
            _shapeRepository.GivenCreateShapeCircleTimes(Times.Never());
            _shapeRepository.GivenCreateShapeSquareTimes(Times.Never());
        }

        [Fact]
        public void HandleCreateCircleFail_IdExists()
        {
            //Arrange
            _shapeRepository.GivenIdExist();

            var shapeApplicationService =
                new ShapeApplicationService(_shapeRepository.Object);

            //Act
            try
            {
                shapeApplicationService.HandleCreate(new CreateCircle("123",3));
            }
            catch (Exception ex)
            {

                ex.Should().BeOfType<ArgumentException>();
            }

            //Assert
            _shapeRepository.GivenIdCalledTimes(Times.Once());
            _shapeRepository.GivenCreateShapeSquareTimes(Times.Never());
            _shapeRepository.GivenCreateShapeCircleTimes(Times.Never());
            _shapeRepository.GivenCreateShapeRectangleTimes(Times.Never());
        }

        [Fact]
        public void HandleCreateSquareFail_IdExists()
        {
            //Arrange
            _shapeRepository.GivenIdExist();

            var shapeApplicationService =
                new ShapeApplicationService(_shapeRepository.Object);

            //Act
            try
            {
                shapeApplicationService.HandleCreate(new CreateSquare("123", 3));
            }
            catch (Exception ex)
            {

                ex.Should().BeOfType<ArgumentException>();
            }

            //Assert
            _shapeRepository.GivenIdCalledTimes(Times.Once());
            _shapeRepository.GivenCreateShapeSquareTimes(Times.Never());
            _shapeRepository.GivenCreateShapeCircleTimes(Times.Never());
            _shapeRepository.GivenCreateShapeRectangleTimes(Times.Never());
        }

        [Fact]
        public void HandleCreateRectangleFail_IdExists()
        {
            //Arrange
            _shapeRepository.GivenIdExist();

            var shapeApplicationService =
                new ShapeApplicationService(_shapeRepository.Object);

            //Act
            try
            {
                shapeApplicationService.HandleCreate(new CreateRectangle("123", 3,4));
            }
            catch (Exception ex)
            {

                ex.Should().BeOfType<ArgumentException>();
            }

            //Assert
            _shapeRepository.GivenIdCalledTimes(Times.Once());
            _shapeRepository.GivenCreateShapeSquareTimes(Times.Never());
            _shapeRepository.GivenCreateShapeCircleTimes(Times.Never());
            _shapeRepository.GivenCreateShapeRectangleTimes(Times.Never());
        }

        [Fact]
        public void HandleCreateCircleFail_InvalidShapeParameters()
        {
            //Arrange
            _shapeRepository.GivenIdNotExist();
            _shapeRepository.GivenInvalidCircleParameters();

            var shapeApplicationService =
                new ShapeApplicationService(_shapeRepository.Object);

            //Act
            try
            {
                shapeApplicationService.HandleCreate(new CreateCircle("123", -3));
            }
            catch (Exception ex)
            {

                ex.Should().BeOfType<ArgumentOutOfRangeException>();
            }

            //Assert
            _shapeRepository.GivenIdCalledTimes(Times.Once());
            _shapeRepository.GivenCreateShapeCircleTimes(Times.Once());
            _shapeRepository.GivenCreateShapeSquareTimes(Times.Never());
            _shapeRepository.GivenCreateShapeRectangleTimes(Times.Never());
        }

        [Fact]
        public void HandleCreateSquareFail_InvalidShapeParameters()
        {
            //Arrange
            _shapeRepository.GivenIdNotExist();
            _shapeRepository.GivenInvalidSquareParameters();

            var shapeApplicationService =
                new ShapeApplicationService(_shapeRepository.Object);

            //Act
            try
            {
                shapeApplicationService.HandleCreate(new CreateSquare("123", -3));
            }
            catch (Exception ex)
            {

                ex.Should().BeOfType<ArgumentOutOfRangeException>();
            }

            //Assert
            _shapeRepository.GivenIdCalledTimes(Times.Once());
            _shapeRepository.GivenCreateShapeSquareTimes(Times.Once());
            _shapeRepository.GivenCreateShapeCircleTimes(Times.Never());
            _shapeRepository.GivenCreateShapeRectangleTimes(Times.Never());
        }

        [Theory]
        [InlineData("123",-3,2)]
        [InlineData("123",3,3)]
        public void HandleCreateRectangleFail_InvalidShapeParameters(string id, double width, double height)
        {
            //Arrange
            _shapeRepository.GivenIdNotExist();
            _shapeRepository.GivenInvalidRectangleParameters();

            var shapeApplicationService =
                new ShapeApplicationService(_shapeRepository.Object);

            //Act
            try
            {
                shapeApplicationService.HandleCreate(new CreateRectangle(id, width, height));
            }
            catch (Exception ex)
            {

                ex.Should().BeOfType<ArgumentOutOfRangeException>();
            }

            //Assert
            _shapeRepository.GivenIdCalledTimes(Times.Once());
            _shapeRepository.GivenCreateShapeRectangleTimes(Times.Once());
            _shapeRepository.GivenCreateShapeCircleTimes(Times.Never());
            _shapeRepository.GivenCreateShapeSquareTimes(Times.Never());
        }
    }
}