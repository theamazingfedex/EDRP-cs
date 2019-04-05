using System;
using System.Collections.Generic;

namespace EDRP.Shipyard.Models
{
    public class ShipyardMessage
    {
        public bool horizons { get; set; }
        public int marketId { get; set; }
        public List<string> ships { get; set; }
        public string stationName { get; set; }
        public string systemName { get; set; }
        public DateTime timestamp { get; set; }
    }
}