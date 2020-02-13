using System.Text;

namespace BerlinClock.ClockConverters.Berlin.FormatterStrategies
{
    internal class VisualStringFormatterStrategy : IClockFormatterStrategy
    {
        private const string ElementOffSymbol = "O";

        private readonly string[] SecondsMask = new[] { "Y" };

        private readonly string[] HighHoursMask = new[] { "R", "R", "R", "R" };

        private readonly string[] LowHoursMask = new[] { "R", "R", "R", "R" };

        private readonly string[] HighMinutesMask = new[] { "Y", "Y", "R", "Y", "Y", "R", "Y", "Y", "R", "Y", "Y" };

        private readonly string[] LowMinutesMask = new[] { "Y", "Y", "Y", "Y" };

        public string Format(ClockModel clockModel)
        {
            return ParseClockModel(clockModel);
        }

        private string ParseClockModel(ClockModel clockModel)
        {
            var result = new StringBuilder();

            result.AppendLine(ParseClockSegment(clockModel.Seconds, SecondsMask));
            result.AppendLine(ParseClockSegment(clockModel.HighHours, HighHoursMask));
            result.AppendLine(ParseClockSegment(clockModel.LowHours, LowHoursMask));
            result.AppendLine(ParseClockSegment(clockModel.HighMinutes, HighMinutesMask));
            result.Append(ParseClockSegment(clockModel.LowMinutes, LowMinutesMask));

            return result.ToString();
        }

        private string ParseClockSegment(ushort timeValue, string[] hoursMask)
        {
            for (int i = timeValue; i < hoursMask.Length; i++)
            {
                hoursMask[i] = ElementOffSymbol;
            }

            return string.Join(string.Empty, hoursMask);
        }
    }
}