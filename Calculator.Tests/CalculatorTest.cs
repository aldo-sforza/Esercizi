using Xunit;
using FluentAssertions;
using System.Xml.Schema;

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
        [InlineData(1,2,3)]
        [InlineData(2,2,4)]
        [InlineData(2,3,5)]

        public void SubstractTwoNumberSuccess(int a1, int a2, int result)
        {
            var calculator = new Model.Calculator();
            var actualResult = calculator.Subtract(a1,a2);
            actualResult.Should().Be(result);
        }

       

       
    }
}