using Xunit;
using FinancialInstrumentCategorization.Application;
using FinancialInstrumentCategorization.Domain;

namespace FinancialInstrumentCategorization.Tests.Application
{
    public class FinancialInstrumentCategorizerTests
    {
        [Fact]
        public void Constructor_ShouldCreateInstance()
        {
            // Arrange & Act
            var categorizer = new FinancialInstrumentCategorizer();

            // Assert
            Assert.NotNull(categorizer);
        }

        [Theory]
        [InlineData(500000, "Low Value")]
        [InlineData(2000000, "Medium Value")]
        [InlineData(10000000, "High Value")]
        public void Categorize_ShouldReturnCorrectCategory(decimal marketValue, string expectedCategory)
        {
            // Arrange
            var categorizer = new FinancialInstrumentCategorizer();
            var instrument = new FinancialInstrument(marketValue, "Stock");

            // Act
            var actualCategory = categorizer.Categorize(instrument);

            // Assert
            Assert.Equal(expectedCategory, actualCategory);
        }
    }
}
