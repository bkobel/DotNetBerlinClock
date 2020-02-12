using System;

namespace BerlinClock.Parsers
{
    public interface IStringTimeParser
    {
        DateTime Parse(string rawTime);
    }
}