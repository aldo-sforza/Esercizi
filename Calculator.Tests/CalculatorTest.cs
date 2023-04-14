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
        public void Add(int a1, int a2, int result)
        {
            //arrange
            var calculator = new Model.Calculator();

            //act
            var actualResult =calculator.Add(a1,a2);

            //assert
            actualResult.Should().Be(result);

        }

        [Theory]
        [InlineData(1,2,3)]
       public void AddDec(float a1, float a2, float result)
        {
            var calculator = new Model.Calculator();

            var actualResult = calculator.AddDec(a1,a2);

            actualResult.Should().Be(result);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        public void Subtract(int a1, int a2, int result) 
        {
            var calculator = new Model.Calculator();

            var actualResult = calculator.Sub(a1,a2);

            actualResult.Should().Be(result);
        }
    }
}