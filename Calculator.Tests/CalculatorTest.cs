using Xunit;
using FluentAssertions;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void AddTwoNumberSuccess()
        {
            //arrange
            var calculator = new Model.Calculator();

            //act
            var actualResult =calculator.Add(1,2);

            //assert
            actualResult.Should().Be(3);

        }

        [Fact]
        public void AddTwoNumberSuccessAgain()
        {
            //arrange
            var calculator = new Model.Calculator();

            //act
            var actualResult = calculator.Add(2, 2);

            //assert
            actualResult.Should().Be(4);

        }
    }
}