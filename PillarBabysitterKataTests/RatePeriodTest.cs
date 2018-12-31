using Microsoft.VisualStudio.TestTools.UnitTesting;
using PillarBabysitterKata.Classes;
using System;

namespace BabsitterKataTests
{
    [TestClass]
    public class RatePeriodTest
    {
        [TestMethod]
        public void Ctor()
        {
            var startTime = DateTime.Parse("1:00PM");
            var endTime = DateTime.Parse("8:00PM");
            decimal rate = 10.00M;
            var ratePeriod = new RatePeriod(startTime, endTime, rate);
            Assert.AreEqual(startTime, ratePeriod.StartTime);
            Assert.AreEqual(endTime, ratePeriod.EndTime);
            Assert.AreEqual(rate, ratePeriod.Rate);
        }
    }
}