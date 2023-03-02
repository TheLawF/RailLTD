namespace RailLTD
{
    public struct TimeTable
    {
        public string Id { get; }
        public int Interval { get; }

        public TimeTable(string id, int interval)
        {
            Id = id;
            Interval = interval;
        }
    }
}