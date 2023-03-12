using System.Collections.Generic;

namespace RailLTD
{
    public class JsonConfigure
    {
        public RailLine Line { get; set; }
        public int Interval { get; set; }

        public JsonConfigure(RailLine line, int interval)
        {
            Line = line;
            Interval = interval;
        }
    }
    
}