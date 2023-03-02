using System.Collections.Generic;
using System.Drawing;

namespace RailLTD
{
    public class RailLine
    {
        public string Id;
        public int Number;
        public List<Station> Stations;
        public Color LineColor;

        public RailLine(string id, int number, List<Station> stations, Color lineColor)
        {
            Id = id;
            Number = number;
            Stations = stations;
            LineColor = lineColor;
        }
    }
}