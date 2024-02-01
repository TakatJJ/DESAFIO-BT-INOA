using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketGuide
{
    internal class StocksINFO
    {
        public string Currency { get; set; }
        public double TwoHundredDayAverage { get; set; }
        public double TwoHundredDayAverageChange { get; set; }
        public double TwoHundredDayAverageChangePercent { get; set; }
        public long MarketCap { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public double RegularMarketChange { get; set; }
        public double RegularMarketChangePercent { get; set; }
        public DateTime RegularMarketTime { get; set; }
        public double RegularMarketPrice { get; set; }
        public double RegularMarketDayHigh { get; set; }
        public string RegularMarketDayRange { get; set; }
        public double RegularMarketDayLow { get; set; }
        public int RegularMarketVolume { get; set; }
        public double RegularMarketPreviousClose { get; set; }
        public double RegularMarketOpen { get; set; }
        public int AverageDailyVolume3Month { get; set; }
        public int AverageDailyVolume10Day { get; set; }
        public double FiftyTwoWeekLowChange { get; set; }
        public double FiftyTwoWeekLowChangePercent { get; set; }
        public string FiftyTwoWeekRange { get; set; }
        public double FiftyTwoWeekHighChange { get; set; }
        public double FiftyTwoWeekHighChangePercent { get; set; }
        public double FiftyTwoWeekLow { get; set; }
        public double FiftyTwoWeekHigh { get; set; }
        public string Symbol { get; set; }
        public double PriceEarnings { get; set; }
        public double EarningsPerShare { get; set; }
        public string LogoUrl { get; set; }

    }
}
