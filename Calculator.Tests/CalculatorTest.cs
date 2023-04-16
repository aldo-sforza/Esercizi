using FluentAssertions;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 2, 4)]
        [InlineData(2, 3, 5)]
        [InlineData(2, 4, 6)]
        public void AddTwoNumberSuccess(int a1, int a2, int result)
        {
            //arrange
            var calculator = new Model.Calculator();
            //act
            var actualResult = calculator.Add(a1, a2);
            //assert
            actualResult.Should().Be(result);

        }


        [Theory]
        [InlineData(1.1, 2.2, 3.3)]
        [InlineData(2.1, 2.1, 4.2)]
        public void AddTwoDoubleNumberSuccess(double a1, double a2, double result)
        {
            //arrange
            var calculator = new Model.Calculator();

            //act
            var actualResult = calculator.Add(a1, a2);

            //assert
            actualResult.Should().Be(result);

        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(2, 2, 0)]
        public void SubtractOf(int a1, int a2, int result)
        {

            //arrange
            var calculator = new Model.Calculator();

            //act
            int actualResult = calculator.Subtract(a1, a2);

            //assert
            actualResult.Should().Be(result);
        }


    }
}