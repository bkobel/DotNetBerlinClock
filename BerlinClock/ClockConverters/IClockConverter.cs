using System;

namespace BerlinClock.ClockConverters
{
    public interface IClockConverter
    {
        string ToStringRepresentation(DateTime inputTime);
    }
}
