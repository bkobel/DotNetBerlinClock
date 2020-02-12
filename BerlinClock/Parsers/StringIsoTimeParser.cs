using System;

namespace BerlinClock.Parsers
{
    public class StringIsoTimeParser : IStringTimeParser
    {
        public DateTime Parse(string rawTime)
        {
            if (string.IsNullOrEmpty(rawTime))
            {
                throw new ArgumentException("Invalid argument provided", nameof(rawTime));
            }

            if (!DateTime.TryParse(rawTime, out var result))
            {
                throw new ArgumentException("Invalid time format provided, ISO 8601 is required");
            }

            return result;
        }

        //todo: probably add custom validator
    }
}