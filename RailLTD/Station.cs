using System.Collections.Generic;

namespace RailLTD
{
    public class Station
    {
        public string Name;
        public string Exit;
        public int ExitIndex;
        public bool IsInterchangeStation;
        public List<RailLine> TransferableLines;
        
        public Station(){}

        public Station(string name, string exit, int exitIndex)
        {
            Name = name;
            Exit = exit;
            ExitIndex = exitIndex;
        }

        public Station(string name, string exit, int exitIndex,
            bool isInterchangeStation, List<RailLine> transferableLines)
        {
            Name = name;
            Exit = exit;
            ExitIndex = exitIndex;
            IsInterchangeStation = isInterchangeStation;
            if (IsInterchangeStation)
            {
                TransferableLines = transferableLines;
            }
        }

        public Station(string name)
        {
            Name = name;
            Exit = "A出口";
            ExitIndex = 1;
        }

        public Station(string name, bool isInterchangeStation, List<RailLine> transferableLines)
        {
            Name = name;
            Exit = "A出口";
            ExitIndex = 1;
            IsInterchangeStation = isInterchangeStation;
            if (IsInterchangeStation)
            {
                TransferableLines = transferableLines;
            }
        }
    }
}