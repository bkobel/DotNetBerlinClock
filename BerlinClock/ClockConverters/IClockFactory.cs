namespace BerlinClock.ClockConverters
{
    public interface IClockFactory
    {
        IClockConverter GetClockConverter();
    }
}