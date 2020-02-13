namespace BerlinClock.ClockConverters.Berlin
{
    internal struct ClockModel
    {
        public ushort HighHours { get; }

        public ushort LowHours { get; }

        public ushort HighMinutes { get; }

        public ushort LowMinutes { get; }

        public ushort Seconds { get; }

        public ClockModel(ushort highHours, ushort lowHours, ushort highMinutes, ushort lowMinutes, ushort seconds)
        {
            HighHours = highHours;
            LowHours = lowHours;
            HighMinutes = highMinutes;
            LowMinutes = lowMinutes;
            Seconds = seconds;
        }
    }
}