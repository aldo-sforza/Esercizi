using Xunit;
using FluentAssertions;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(2,2,4)]
        [InlineData(3,2,5)]
        public void AddTwoIntNumberSuccess(int a1, int a2, int result)
        {
            //arrange
            var calculator = new Model.Calculator();

            //act
            var actualResult = calculator.Add(a1,a2);

            //assert
            actualResult.Should().Be(result);

        }

        [Theory]
        [InlineData(2, 1.5, 3.5)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 0.75, 3.75)]
        public void AddTwoFloatNumberSuccess(float a1, float a2, float result)
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(2,2,4)]
        [InlineData(2,3,5)]
        [InlineData(2,4,6)]
        public void AddTwoNumberSuccess(int a1, int a2, int result)
        {
            //arrange
            var calculator = new Model.Calculator();

            //act
            var actualResult = calculator.Add(a1, a2);
            var actualResult =calculator.Add(a1,a2);

            //assert
            actualResult.Should().Be(result);

        }

       
    }
}
        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(2, 2, 0)]
        [InlineData(3, 2, 1)]
        public void SubTwoIntNumberSuccess(int a1, int a2, int result)
        {
            //arrange
            var calculator = new Model.Calculator();

            //act
            var actualResult = calculator.Sub(a1, a2);

            //assert
            actualResult.Should().Be(result);

        }
    }
}