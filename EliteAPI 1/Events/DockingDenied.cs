﻿using System;

namespace EliteAPI
{
    public class DockingDeniedInfo
    {
        public DateTime timestamp { get; set; }
        public string Reason { get; set; }
        public long MarketID { get; set; }
        public string StationName { get; set; }
        public string StationType { get; set; }
    }
}
