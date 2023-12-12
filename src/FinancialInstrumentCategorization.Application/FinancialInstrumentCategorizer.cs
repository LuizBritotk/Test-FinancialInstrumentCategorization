// FinancialInstrumentCategorization.Application

using FinancialInstrumentCategorization.Domain;

namespace FinancialInstrumentCategorization.Application
{
 
    public class FinancialInstrumentCategorizer
    {
        public string Categorize(FinancialInstrument instrument)
        {
            ValidateInstrument(instrument);

            return CategorizeByMarketValue(instrument.MarketValue);
        }

        private void ValidateInstrument(FinancialInstrument instrument)
        {
            if (instrument == null)
                throw new ArgumentNullException(nameof(instrument), "The financial instrument cannot be null.");

            EnsureNonNegativeMarketValue(instrument.MarketValue);
        }

        private void EnsureNonNegativeMarketValue(decimal marketValue)
        {
            if (marketValue < 0)
                throw new ArgumentException("The market value cannot be negative.", nameof(marketValue));
        }

        private string CategorizeByMarketValue(decimal marketValue)
        {
            if (marketValue < 1000000)
                return "Low Value";
            else if (marketValue <= 5000000)
                return "Medium Value";
            else
                return "High Value";
        }
    }
}
