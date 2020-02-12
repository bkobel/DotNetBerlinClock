using BerlinClock.ClockConverters;
using BerlinClock.Parsers;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        private readonly IStringTimeParser _stringTimeParser;
        private readonly IClockFactory _berlinClockFactory;

        public TimeConverter()
        {
            _stringTimeParser = new StringIsoTimeParser();
            _berlinClockFactory = new BerlinToVisualRepresentationClockFactory();
        }

        public string Convert(string isoTime)
        {
            var parsedTime = _stringTimeParser.Parse(isoTime);

            return _berlinClockFactory.GetClockConverter().ToStringRepresentation(parsedTime);
        }
    }
}