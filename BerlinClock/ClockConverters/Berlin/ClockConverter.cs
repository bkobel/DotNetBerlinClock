using BerlinClock.ClockConverters.Berlin.FormatterStrategies;
using BerlinClock.Parsers;

namespace BerlinClock.ClockConverters.Berlin
{
    internal class ClockConverter : IClockConverter
    {
        private readonly IClockFormatterStrategy _clockModelFormatterStrategy;

        internal ClockConverter(IClockFormatterStrategy clockModelFormatterStrategy)
        {
            _clockModelFormatterStrategy = clockModelFormatterStrategy;
        }

        public string ToStringRepresentation(Double24HClockModel inputTime)
        {
            var clockModel = ParseClockModel(inputTime);

            return _clockModelFormatterStrategy.Format(clockModel);
        }

        private ClockModel ParseClockModel(Double24HClockModel inputTime)
        {
            var result = new ClockModel(ParseHighHours(inputTime),
                                        ParseLowHours(inputTime),
                                        ParseHighMinutes(inputTime),
                                        ParseLowMinutes(inputTime),
                                        ParseSeconds(inputTime));

            return result;
        }

        private ushort ParseHighHours(Double24HClockModel inputTime)
        {
            return (ushort)(inputTime.Hours / 5);
        }

        private ushort ParseLowHours(Double24HClockModel inputTime)
        {
            return (ushort)(inputTime.Hours % 5);
        }

        private ushort ParseHighMinutes(Double24HClockModel inputTime)
        {
            return (ushort)(inputTime.Minutes / 5);
        }

        private ushort ParseLowMinutes(Double24HClockModel inputTime)
        {
            return (ushort)(inputTime.Minutes % 5);
        }

        private ushort ParseSeconds(Double24HClockModel inputTime)
        {
            return inputTime.Seconds % 2 > 0 ? (ushort)0 : (ushort)1;
        }
    }
}