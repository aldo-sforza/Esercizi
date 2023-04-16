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

        #region Create Success
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
        #endregion

        #region Create Fail

        #region Id Exists
        [Fact]
        public void CreateCircleFail_IdExists()
        {
            _shapeRepository.GivenIdExist();

            var shapeApplicationService = new ShapeApplicationService(_shapeRepository.Object);
            try
            {
                shapeApplicationService.HandleCommand(new CreateCircle("123", 3));
            }catch (Exception ex){
                ex.Should().BeOfType<ArgumentException>();
            }

            _shapeRepository.GivenCreateShapeCircleTimes(Times.Once());
            _shapeRepository.GivenCreateShapeRectangleTimes(Times.Never());
            _shapeRepository.GivenCreateShapeSquareTimes(Times.Never());
        }

        [Fact]
        public void CreateRectangleFail_IdExists()
        {
            _shapeRepository.GivenIdExist();

            var shapeApplicationService = new ShapeApplicationService(_shapeRepository.Object);

            try
            {
                shapeApplicationService.HandleCommand(new CreateRectangle("123", 2, 5));
            }catch(Exception ex)
            {
                ex.Should().BeOfType<ArgumentException>();
            }

            _shapeRepository.GivenCreateShapeRectangleTimes(Times.Once());
            _shapeRepository.GivenCreateShapeCircleTimes(Times.Never());
            _shapeRepository.GivenCreateShapeSquareTimes(Times.Never());
        }

        [Fact]
        public void CreateSquareFail_IdExists()
        {
            _shapeRepository.GivenIdExist();
            var shapeApplicationService = new ShapeApplicationService(_shapeRepository.Object);

            try
            {
                shapeApplicationService.HandleCommand(new CreateSquare("123", 2));
            }catch (Exception ex)
            {
                ex.Should().BeOfType<ArgumentException>();
            }

            _shapeRepository.GivenCreateShapeSquareTimes(Times.Once());
            _shapeRepository.GivenCreateShapeCircleTimes(Times.Never());
            _shapeRepository.GivenCreateShapeRectangleTimes(Times.Never());
        }
        #endregion
        #region Invalid Parameters
        [Fact]
        public void CreateCircleFail_InvalidParameters()
        {
            _shapeRepository.GivenInvalidParameters();

            var shapeApplicationService = new ShapeApplicationService(_shapeRepository.Object);

            try
            {
                shapeApplicationService.HandleCommand(new CreateCircle("123", -2));
            }catch (Exception ex)
            {
                ex.Should().BeOfType<ArgumentOutOfRangeException>();
            }

            _shapeRepository.GivenCreateShapeCircleTimes(Times.Once());
            _shapeRepository.GivenCreateShapeRectangleTimes(Times.Never());
            _shapeRepository.GivenCreateShapeSquareTimes(Times.Never());
        }

        [Theory]
        [InlineData("123", -2,1)]
        [InlineData("123", 2,-1)]
        [InlineData("123", 2,2)]
        [InlineData("123", -2,-2)]
        public void CreateRectangleFail_InvalidParameters(string id, double width, double height)
        {
            _shapeRepository.GivenInvalidParameters();

            var shapeApplicationService = new ShapeApplicationService(_shapeRepository.Object);

            try
            {
                shapeApplicationService.HandleCommand(new CreateRectangle(id, width, height));
            }catch(Exception ex)
            {
                ex.Should().BeOfType<ArgumentOutOfRangeException>();
            }

            _shapeRepository.GivenCreateShapeRectangleTimes(Times.Once());
            _shapeRepository.GivenCreateShapeCircleTimes(Times.Never());
            _shapeRepository.GivenCreateShapeSquareTimes(Times.Never());
        }
        [Fact]
        public void CreateSquareFail_InvalidParameters()
        {
            _shapeRepository.GivenInvalidParameters();

            var shapeApplicationService = new ShapeApplicationService(_shapeRepository.Object);

            try
            {
                shapeApplicationService.HandleCommand(new CreateSquare("123", -2));
            }catch(Exception ex)
            {
                ex.Should().BeOfType<ArgumentOutOfRangeException>();
            }

            _shapeRepository.GivenCreateShapeSquareTimes(Times.Once());
            _shapeRepository.GivenCreateShapeCircleTimes(Times.Never());
            _shapeRepository.GivenCreateShapeRectangleTimes(Times.Never());
        }
        #endregion
        
        #endregion
    }
}