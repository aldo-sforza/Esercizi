using Xunit;
using FluentAssertions;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
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
            var actualResult =calculator.Add(a1,a2);

            //assert
            actualResult.Should().Be(result);

        }

        [Theory]
        [InlineData(1.5,2.5,4)]
        [InlineData(2.90,2.34,5.24)]
        [InlineData(2.124,3.752,5.876)]
        public void AddTwoDoubleNumberSuccess(double a1, double a2, double result)
        {
            //arrange
            var calculator = new Model.Calculator();

            //act
            var actualResult = calculator.Add(a1, a2);

            //assert
            actualResult.Should().BeApproximately(result,2f);
        }
       
    }
}