namespace RailLTD
{
    public class Station
    {
        public string Name;
        public string Exit;
        public int ExitIndex;

        public Station(string name, string exit, int exitIndex)
        {
            Name = name;
            Exit = exit;
            ExitIndex = exitIndex;
        }
        
    }
}