using BerlinClock.Parsers;

namespace BerlinClock.ClockConverters
{
    public interface IClockConverter
    {
        string ToStringRepresentation(Double24HClockModel inputTime);
    }
}
