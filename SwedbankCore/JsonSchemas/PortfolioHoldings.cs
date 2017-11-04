using System;
using System.Collections.Generic;
using System.Text;

namespace SwedbankCore.JsonSchemas
{
    public class PortfolioHoldings
    {
        public List<FundAccount> FundAccounts { get; set; }
        public List<object> EndowmentInsurances { get; set; }
        public List<object> EquityTraders { get; set; }
        public List<object> SavingsAccounts { get; set; }
        public List<InvestmentSaving> InvestmentSavings { get; set; }
        public string ServerTime { get; set; }
    }

    public class PerformanceAmount
    {
        public string CurrencyCode { get; set; }
        public string Amount { get; set; }
    }

    public class Performance
    {
        public string Percent { get; set; }
        public PerformanceAmount Amount { get; set; }
    }

    public class MarketValue
    {
        public string CurrencyCode { get; set; }
        public string Amount { get; set; }
    }

    public class Holding
    {
        public string Name { get; set; }
        public string FundCode { get; set; }
    }

    public class FundAccount
    {
        public string Type { get; set; }
        public bool RightOfDisposal { get; set; }
        public Performance Performance { get; set; }
        public MarketValue MarketValue { get; set; }
        public List<Holding> Holdings { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public string ClearingNumber { get; set; }
        public string AccountNumber { get; set; }
        public string FullyFormattedNumber { get; set; }
    }

    public class TotalValue
    {
        public string CurrencyCode { get; set; }
        public string Amount { get; set; }
    }

    public class InvestmentSaving
    {
        public TotalValue TotalValue { get; set; }
        public string Type { get; set; }
        public bool RightOfDisposal { get; set; }
        public Performance Performance { get; set; }
        public MarketValue MarketValue { get; set; }
        public List<object> Holdings { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public string ClearingNumber { get; set; }
        public string AccountNumber { get; set; }
        public string FullyFormattedNumber { get; set; }
    }
}