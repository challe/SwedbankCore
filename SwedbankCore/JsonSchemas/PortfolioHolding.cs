using System;
using System.Collections.Generic;
using System.Text;

namespace SwedbankCore.JsonSchemas
{
    public class PortfolioHolding
    {
        public DetailedHolding DetailedHolding { get; set; }
        public string ServerTime { get; set; }
    }

    public class DetailedHolding
    {
        public string Type { get; set; }
        public bool RightOfDisposal { get; set; }
        public Performance Performance { get; set; }
        public MarketValue MarketValue { get; set; }
        public List<SubHolding> Holdings { get; set; }
        public AcquisitionValue AcquisitionValue { get; set; }
        public ChartData ChartData { get; set; }
        public List<Placement> Placements { get; set; }
        public List<Operation> Operations { get; set; }
        public string EncompassedHoldings { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public string ClearingNumber { get; set; }
        public string AccountNumber { get; set; }
        public string FullyFormattedNumber { get; set; }
    }

    public class AcquisitionValue
    {
        public string CurrencyCode { get; set; }
        public string Amount { get; set; }
    }

    public class Value
    {
        public string CurrencyCode { get; set; }
        public string Amount { get; set; }
    }

    public class Allocation
    {
        public string Type { get; set; }
        public Value Value { get; set; }
        public string Text { get; set; }
        public string Percent { get; set; }
    }

    public class ChartData
    {
        public List<Allocation> Allocations { get; set; }
    }

    public class FundRate
    {
        public string CurrencyCode { get; set; }
        public string Amount { get; set; }
    }

    public class ChangeOfValue
    {
        public string CurrencyCode { get; set; }
        public string Amount { get; set; }
    }

    public class SubHolding
    {
        public string Name { get; set; }
        public string FundCode { get; set; }
        public bool Fundguide { get; set; }
        public FundRate FundRate { get; set; }
        public AcquisitionValue AcquisitionValue { get; set; }
        public string NumberOfFundParts { get; set; }
        public ChangeOfValue ChangeOfValue { get; set; }
        public string ChangeOfValuePercent { get; set; }
        public MarketValue MarketValue { get; set; }
        public Links Links { get; set; }
    }

    public class AggregatedMarketValue
    {
        public string CurrencyCode { get; set; }
        public string Amount { get; set; }
    }

    public class SubPlacement
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public List<SubHolding> Holdings { get; set; }
        public AggregatedMarketValue AggregatedMarketValue { get; set; }
    }

    public class Placement
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public List<SubPlacement> SubPlacements { get; set; }
    }

    public class Operation
    {
        public string Type { get; set; }
        public Links Links { get; set; }
    }
}