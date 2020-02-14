using System;

namespace BerlinClock.Parsers
{
    public interface IStringTimeParser
    {
        Double24HClockModel Parse(string rawTime);
    }
}