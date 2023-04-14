using FluentAssertions;
using Shapes.Model;

namespace ShapesTests
{
    public class UnitTest1
    {
        [Fact]
        public void AddCircle()
        {
            var shapeRepository = new ShapeRepository();

            var circle = new Circle("xyz",2);
            shapeRepository.Add(circle);

            shapeRepository.Shapes.Should().Contain(circle);
        }
        [Fact]
        public void AddRectangle()
        {
            var shapeRepository = new ShapeRepository();

            var rectangle = new Rectangle("xyz", 2,3);
            shapeRepository.Add(rectangle);

            shapeRepository.Shapes.Should().Contain(rectangle);
        }

        [Fact]
        public void AddSquare()
        {
            var shapeRepository = new ShapeRepository();

            var square = new Square("xyz",  3);
            shapeRepository.Add(square);

            shapeRepository.Shapes.Should().Contain(square);
        }

        [Fact]
        public void AddAllShapes()
        {
            var shapeRepository = new ShapeRepository();

            var circle = new Circle("xyz1", 2);
            shapeRepository.Add(circle);
            var square = new Square("xyz2", 3);
            shapeRepository.Add(square);
            var rectangle = new Rectangle("xyz3", 2, 3);
            shapeRepository.Add(rectangle);

            shapeRepository.Shapes
                .Should().Contain(square);
            shapeRepository.Shapes
               .Should().Contain(circle);
            shapeRepository.Shapes
               .Should().Contain(rectangle);
        }

        [Fact]
        public void GetCircles()
        {
            var shapeRepository = new ShapeRepository();

            var circle = new Circle("c1", 2);
            shapeRepository.Add(circle);
            var circle1 = new Circle("c2", 2);
            shapeRepository.Add(circle1);
            var square = new Square("s1", 3);
            shapeRepository.Add(square);
            var rectangle = new Rectangle("r1", 2, 3);
            shapeRepository.Add(rectangle);

            var circles= shapeRepository.GetCircles();

            circles.Should().Contain(circle);
            circles.Should().Contain(circle1);
            circles.Should().ContainItemsAssignableTo<Circle>();

        }

        [Fact]
        public void GetSquares()
        {
            var shapeRepository = new ShapeRepository();

            var circle = new Circle("c1", 2);
            shapeRepository.Add(circle);
            var circle1 = new Circle("c2", 2);
            shapeRepository.Add(circle1);
            var square = new Square("s1", 3);
            shapeRepository.Add(square);
            var square1 = new Square("s2", 3);
            shapeRepository.Add(square1);
            var rectangle = new Rectangle("r1", 2, 3);
            shapeRepository.Add(rectangle);

            var squares = shapeRepository.GetSquares();

            squares.Should().Contain(square);
            squares.Should().Contain(square1);
            squares.Should().ContainItemsAssignableTo<Square>();

        }


        [Fact]
        public void GetRectangles()
        {
            var shapeRepository = new ShapeRepository();

            var circle = new Circle("c1", 2);
            shapeRepository.Add(circle);
            var circle1 = new Circle("c2", 2);
            shapeRepository.Add(circle1);
            var square = new Square("s1", 3);
            shapeRepository.Add(square);
            var square1 = new Square("s2", 3);
            shapeRepository.Add(square1);
            var rectangle = new Rectangle("r1", 2, 3);
            shapeRepository.Add(rectangle);
            var rectangle1 = new Rectangle("r2", 2, 3);
            shapeRepository.Add(rectangle1);

            var rectangles = shapeRepository.GetRectangles();

            rectangles.Should().Contain(rectangle);
            rectangles.Should().Contain(rectangle1);
            rectangles.Should().ContainItemsAssignableTo<Rectangle>();

        }
    }
}