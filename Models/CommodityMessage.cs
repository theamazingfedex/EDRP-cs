using System;
using System.Collections.Generic;

namespace EDRP.Commodity.Models
{
    public class CommodityMessage
    {
        public List<Commodity> commodities { get; set; }
        public List<Economy> economies { get; set; }
        public int marketId { get; set; }
        public List<string> prohibited { get; set; }
        public string stationName { get; set; }
        public string systemName { get; set; }
        public DateTime timestamp { get; set; }
    }

    public class Commodity
    {
        public int buyPrice { get; set; }
        public int demand { get; set; }
        public int demandBracket { get; set; }
        public int meanPrice { get; set; }
        public string name { get; set; }
        public int sellPrice { get; set; }
        public int stock { get; set; }
        public int stockBracket { get; set; }
    }

    public class Economy
    {
        public string name { get; set; }
        public int proportion { get; set; }
    }
}