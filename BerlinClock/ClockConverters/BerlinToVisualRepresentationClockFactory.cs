using BerlinClock.ClockConverters.Berlin;
using BerlinClock.ClockConverters.Berlin.FormatterStrategies;

namespace BerlinClock.ClockConverters
{
    public class BerlinToVisualRepresentationClockFactory : IClockFactory
    {
        public IClockConverter GetClockConverter()
        {
            return new ClockConverter(new VisualStringFormatterStrategy());
        }
    }
}