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

        [TestMethod]
        public void JobsOnHalfHoursWork()
        {
            var periodStartTime = DateTime.Parse("10:00AM");
            var periodEndTime = DateTime.Parse("4:00PM");
            decimal periodRate = 10.00M;
            var ratePeriod = new RatePeriod(periodStartTime, periodEndTime, periodRate);
            var jobStartTime = DateTime.Parse("12:30 PM");
            var jobEndTime = DateTime.Parse("3:30 PM");
            Assert.AreEqual(3, ratePeriod.HrsInRatePeriod(jobStartTime, jobEndTime));
            Assert.AreEqual(30.00M, ratePeriod.CalculatePayment(jobStartTime, jobEndTime));

        }

        [TestMethod]
        public void StartTimeAfterPeriodEnd()
        {
            var startTime = DateTime.Parse("12:00PM");
            var endTime = DateTime.Parse("3:00PM");
            decimal Rate = 10.00M;
            var ratePeriod = new RatePeriod(startTime, endTime, Rate);
            var jobStartTime = DateTime.Parse("5:00PM");
            var jobEndTime = DateTime.Parse("10:00PM");
            Assert.AreEqual(0, ratePeriod.HrsInRatePeriod(jobStartTime, jobEndTime));
            Assert.AreEqual(0M, ratePeriod.CalculatePayment(jobStartTime, jobEndTime));
        }

        [TestMethod]
        public void EndTimeBeforePeriodStart()
        {
            var startTime = DateTime.Parse("12:00PM");
            var endTime = DateTime.Parse("4:00PM");
            decimal rate = 10.00M;
            var ratePeriod = new RatePeriod(startTime, endTime, rate);
            var jobStartTime = DateTime.Parse("5:00AM");
            var jobEndTime = DateTime.Parse("10:00AM");
            Assert.AreEqual(0, ratePeriod.HrsInRatePeriod(jobStartTime, jobEndTime));
            Assert.AreEqual(0M, ratePeriod.CalculatePayment(jobStartTime, jobEndTime));
        }

        [TestMethod]
        public void StartTimeBeforePeriodStart()
        {
            var startTime = DateTime.Parse("12:00PM");
            var endTime = DateTime.Parse("4:00PM");
            decimal rate = 10.00M;
            var ratePeriod = new RatePeriod(startTime, endTime, rate);
            var jobStartTime = DateTime.Parse("10:00AM");
            var jobEndTime = DateTime.Parse("3:00PM");
            Assert.AreEqual(3, ratePeriod.HrsInRatePeriod(jobStartTime, jobEndTime));
            Assert.AreEqual(30.00M, ratePeriod.CalculatePayment(jobStartTime, jobEndTime));
        }

        [TestMethod]
        public void EndTimeAfterPeriodEnd()
        {
            var startTime = DateTime.Parse("12:00PM");
            var endTime = DateTime.Parse("4:00PM");
            decimal rate = 10.00M;
            var ratePeriod = new RatePeriod(startTime, endTime, rate);
            var jobStartTime = DateTime.Parse("1:00PM");
            var jobEndTime = DateTime.Parse("8:00PM");
            Assert.AreEqual(3, ratePeriod.HrsInRatePeriod(jobStartTime, jobEndTime));
            Assert.AreEqual(30.00M, ratePeriod.CalculatePayment(jobStartTime, jobEndTime));  
        }
    }
}