namespace BerlinClock.Parsers
{
    public struct Double24HClockModel
    {
        public ushort Hours { get; }

        public ushort Minutes { get; }

        public ushort Seconds { get; }

        public Double24HClockModel(ushort hours, ushort minutes, ushort seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
    }
}