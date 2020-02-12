namespace BerlinClock.ClockConverters.Berlin.FormatterStrategies
{
    internal interface IClockFormatterStrategy
    {
        string Format(ClockModel clockModel);
    }
}
