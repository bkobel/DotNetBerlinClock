using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace BerlinClock
{
    [Binding]
    public class TheBerlinClockSteps
    {
        private ITimeConverter _timeConverter = new TimeConverter();
        private string _inputTime;

        [When(@"the time is ""(.*)""")]
        public void WhenTheTimeIs(string time)
        {
            _inputTime = time;
        }

        [Then(@"the clock should look like")]
        public void ThenTheClockShouldLookLike(string theExpectedBerlinClockOutput)
        {
            Assert.AreEqual(_timeConverter.Convert(_inputTime), theExpectedBerlinClockOutput);
        }
    }
}