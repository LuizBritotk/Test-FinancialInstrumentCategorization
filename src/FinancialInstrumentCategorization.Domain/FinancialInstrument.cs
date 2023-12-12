// FinancialInstrument.cs

using System;

namespace FinancialInstrumentCategorization.Domain
{
    public class FinancialInstrument
    {
        public decimal MarketValue { get; private set; }


        public string Type { get; private set; }

        public FinancialInstrument(decimal marketValue, string type)
        {
            EnsureValidValues(marketValue, type);

            MarketValue = marketValue;
            Type = type;
        }


        private void EnsureValidValues(decimal marketValue, string type)
        {

            if (marketValue < 0)
                throw new ArgumentException("Market value must be non-negative.");

            if (string.IsNullOrWhiteSpace(type))
                throw new ArgumentException("Type must be specified.");
        }

    }
}
