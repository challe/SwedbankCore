using System;
using System.Collections.Generic;
using System.Text;

namespace SwedbankCore.JsonSchemas
{
    public class PortfolioHoldings
    {
        public List<FundAccount> fundAccounts { get; set; }
        public List<object> endowmentInsurances { get; set; }
        public List<object> equityTraders { get; set; }
        public List<object> savingsAccounts { get; set; }
        public List<InvestmentSaving> investmentSavings { get; set; }
        public string serverTime { get; set; }
    }

    public class Amount
    {
        public string currencyCode { get; set; }
        public string amount { get; set; }
    }

    public class Performance
    {
        public string percent { get; set; }
        public Amount amount { get; set; }
    }

    public class MarketValue
    {
        public string currencyCode { get; set; }
        public string amount { get; set; }
    }

    public class Holding
    {
        public string name { get; set; }
        public string fundCode { get; set; }
    }

    public class FundAccount
    {
        public string type { get; set; }
        public bool rightOfDisposal { get; set; }
        public Performance performance { get; set; }
        public MarketValue marketValue { get; set; }
        public List<Holding> holdings { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public string clearingNumber { get; set; }
        public string accountNumber { get; set; }
        public string fullyFormattedNumber { get; set; }
    }

    public class TotalValue
    {
        public string currencyCode { get; set; }
        public string amount { get; set; }
    }
    public class InvestmentSaving
    {
        public TotalValue totalValue { get; set; }
        public string type { get; set; }
        public bool rightOfDisposal { get; set; }
        public Performance performance { get; set; }
        public MarketValue marketValue { get; set; }
        public List<object> holdings { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public string clearingNumber { get; set; }
        public string accountNumber { get; set; }
        public string fullyFormattedNumber { get; set; }
    }
}
