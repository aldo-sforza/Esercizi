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
        [InlineData(1,2,-1)]
        [InlineData(4,2,2)]
        public void SubTwoNumberSuccess(int a1, int a2, int result)
        {
            //arrange
            var calculator = new Model.Calculator();
            //act
            var actualResult = calculator.Sub(a1, a2);
            //assert
            actualResult.Should().Be(result);
        }

        [Theory]
        [InlineData(1,2,3)]
        [InlineData(4,2,3)]
        public void MulTwoNumberSuccess(int a1, int a2, int result)
        {
            //arrange
            var calculator = new Model.Calculator();
            //act
            var actualResult = calculator.Mul(a1, a2);
            //assert
            actualResult.Should().Be(result);
        }

        [Theory]
        [InlineData(5,2,2.5)]
        [InlineData(6,2,3)]
        public void DivTwoNumberSuccess(int a1, int a2, decimal result)
        {
            //arrange
            var calculator = new Model.Calculator();
            //act
            var actualResult = calculator.Div(a1, a2);
            //assert
            actualResult.Should().Be(result);
        }
    }
}