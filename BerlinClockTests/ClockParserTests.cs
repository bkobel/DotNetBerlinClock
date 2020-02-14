using BerlinClock.Parsers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BerlinClockTests
{
    [TestClass]
    public class StringIsoTimeParserTests
    {
        [DataTestMethod]
        [DataRow("001:00:00")]
        [DataRow("00:000:00")]
        [DataRow("00:00:000")]
        public void Parse_TimeExceedingDoubleDigitValues_ThrowsArgumentException(string invalidTimeString)
        {
            // arrange
            var timeParser = new StringIsoTimeParser();

            // act
            // assert
            Assert.ThrowsException<ArgumentException>(() => timeParser.Parse(invalidTimeString));
        }

        [TestMethod]
        public void Parse_TimeExceeding24H_ThrowsArgumentException()
        {
            // arrange
            var tooBigTimeString = "24:00:01";
            var timeParser = new StringIsoTimeParser();

            // act
            // assert
            Assert.ThrowsException<ArgumentException>(() => timeParser.Parse(tooBigTimeString));
        }
    }
}