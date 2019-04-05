using System;
using System.Collections.Generic;

namespace EDRP.Outfitting.Models
{
    public class OutfittingMessage
    {
        public bool horizons { get; set; }
        public int marketId { get; set; }
        public List<string> modules { get; set; }
        public string stationName { get; set; }
        public string systemName { get; set; }
        public DateTime timestamp { get; set; }
    }
}