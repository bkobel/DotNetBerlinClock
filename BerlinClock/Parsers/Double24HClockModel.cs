using System;

namespace BerlinClock.Parsers
{
    public struct Double24HClockModel
    {
        public ushort Hours { get; }

        public ushort Minutes { get; }

        public ushort Seconds { get; }

        public Double24HClockModel(ushort hours, ushort minutes, ushort seconds)
        {
            if (!ValidateValuesNotExceedingRange(hours, minutes, seconds))
            {
                throw new ArgumentException("Time values exceeding range 00:00:00 - 24:00:00");
            }

            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        private static bool ValidateValuesNotExceedingRange(ushort hours, ushort minutes, ushort seconds)
        {
            if (hours == 24)
            {
                return minutes == 0 && seconds == 0;
            }

            return hours <= 24 && minutes <= 59 && seconds <= 59;
        }
    }
}