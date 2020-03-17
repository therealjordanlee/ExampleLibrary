using ExampleLibrary;
using Xunit;

namespace ExampleLibraryTests
{
    public class ExampleLibraryUnitTests
    {
        private Calculator _calculator = new Calculator();

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(10, 20, 30)]
        [InlineData(5, 6, 11)]
        public void Add_Returns_Expected_Value(int x, int y, int expectedResult)
        {
            var actualResult = _calculator.Add(x, y);
            Assert.Equal(actualResult, expectedResult);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(100, 50, 50)]
        [InlineData(7, 3, 4)]
        public void Subtract_Returns_ExpectedValue(int x, int y, int expectedResult)
        {
            var actualResult = _calculator.Subtract(x, y);
            Assert.Equal(actualResult, expectedResult);
        }
    }
}