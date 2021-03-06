using Xunit;

namespace CodeCalisthenics.Test
{
    public class OperatorsTest
    {
        public Operations.Operators sut;

        public OperatorsTest()
        {
            sut = new Operations.Operators();
        }

        [Theory]
        [InlineData(12.00, 20, 8, 15)]
        [InlineData(15.5, 15, 10, 19)]
        [InlineData(10.25, 17, 5, 13)]
        public void TestPrices(double mealCost, int tipPercent, int taxPercent, double expectedResult)
        {
            var actualResult = sut.Solve(mealCost, tipPercent, taxPercent);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
