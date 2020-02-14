using System;
using System.Text.RegularExpressions;

namespace BerlinClock.Parsers
{
    public class StringIsoTimeParser : IStringTimeParser
    {
        private readonly Regex IsoTimeParserMask = new Regex("^([0-2][0-4]):([0-5][0-9]):([0-5][0-9])$");

        public Double24HClockModel Parse(string rawTime)
        {
            if (string.IsNullOrEmpty(rawTime))
            {
                throw new ArgumentException("Invalid argument provided", nameof(rawTime));
            }

            var timeRegexMatch = IsoTimeParserMask.Match(rawTime);
            if (!timeRegexMatch.Success)
            {
                throw new ArgumentException("Invalid time format provided, ISO 8601 is required");
            }



            return new Double24HClockModel(RetrieveUshort(timeRegexMatch.Groups[1]),
                                            RetrieveUshort(timeRegexMatch.Groups[2]),
                                            RetrieveUshort(timeRegexMatch.Groups[3]));
        }

        private ushort RetrieveUshort(Group group)
        {
            return ushort.Parse(group.Value);
        }
    }
}