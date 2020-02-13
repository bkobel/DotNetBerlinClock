using BerlinClock.ClockConverters.Berlin.FormatterStrategies;
using System;

namespace BerlinClock.ClockConverters.Berlin
{
    internal class ClockConverter : IClockConverter
    {
        private readonly IClockFormatterStrategy _clockModelFormatterStrategy;

        internal ClockConverter(IClockFormatterStrategy clockModelFormatterStrategy)
        {
            _clockModelFormatterStrategy = clockModelFormatterStrategy;
        }

        public string ToStringRepresentation(DateTime inputTime)
        {
            var clockModel = ParseClockModel(inputTime);

            return _clockModelFormatterStrategy.Format(clockModel);
        }

        private ClockModel ParseClockModel(DateTime inputTime)
        {
            var result = new ClockModel
            {
                HighHours = ParseHighHours(inputTime),
                LowHours = ParseLowHours(inputTime),
                HighMinutes = ParseHighMinutes(inputTime),
                LowMinutes = ParseLowMinutes(inputTime),
                Seconds = ParseSeconds(inputTime)
            };

            return result;
        }

        private ushort ParseHighHours(DateTime inputTime)
        {
            return (ushort)(inputTime.Hour / 5);
        }

        private ushort ParseLowHours(DateTime inputTime)
        {
            return (ushort)(inputTime.Hour % 5);
        }

        private ushort ParseHighMinutes(DateTime inputTime)
        {
            return (ushort)(inputTime.Minute / 5);
        }

        private ushort ParseLowMinutes(DateTime inputTime)
        {
            return (ushort)(inputTime.Minute % 5);
        }

        private ushort ParseSeconds(DateTime inputTime)
        {
            return inputTime.Second % 2 > 0 ? (ushort)0 : (ushort)1;
        }
    }
}