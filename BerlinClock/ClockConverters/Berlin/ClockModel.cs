namespace BerlinClock.ClockConverters.Berlin
{
    internal struct ClockModel
    {
        public ushort HighHours { get; set; }

        public ushort LowHours { get; set; }

        public ushort HighMinutes { get; set; }

        public ushort LowMinutes { get; set; }

        public ushort Seconds { get; set; }
    }
}
