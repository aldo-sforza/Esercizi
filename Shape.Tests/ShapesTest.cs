using FluentAssertions;
using Shapes.Model;

namespace Shapes.Tests
{
    public class ShapesTest
    {
        [Theory]
        [InlineData(1,2,"test")]
        public void CreateRectangle(double l1, double l2, string id)
        {
            //Arrange
            var repository = new ShapesRepository();
            //Act
            repository.Create(id, l1, l2);
            //Assert
            repository.Load(id).GetType().Should().Be(typeof(Rectangle));
        }

        [Theory]
        [InlineData(1, 1, "test")]
        public void CreateSquare(double l1, double l2, string id)
        {
            //Arrange
            var repository = new ShapesRepository();
            //Act
            repository.Create(id, l1, l2);
            //Assert
            repository.Load(id).GetType().Should().Be(typeof(Square));
        }

        [Theory]
        [InlineData(1, "test")]
        public void CreateCircle(double l1, string id)
        {
            //Arrange
            var repository = new ShapesRepository();
            //Act
            repository.Create(id, l1);
            //Assert
            repository.Load(id).GetType().Should().Be(typeof(Circle));
        }
    }
}