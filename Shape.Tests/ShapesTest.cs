using FluentAssertions;
using Shapes.Model;
using Xunit;

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
            repository.CreateRectangle(id, l1, l2);
            //Assert
            repository.Exists(id);
        }

        [Theory]
        [InlineData(1, "test")]
        public void CreateSquare(double l1, string id)
        {
            //Arrange
            var repository = new ShapesRepository();
            //Act
            repository.CreateSquare(id, l1);
            //Assert
            repository.Exists(id);

        }

        [Theory]
        [InlineData(1, "test")]
        public void CreateCircle(double l1, string id)
        {
            //Arrange
            var repository = new ShapesRepository();
            //Act
            repository.CreateCircle(id, l1);
            //Assert
            repository.Exists(id);
        }
    }
}