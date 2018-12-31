using Microsoft.VisualStudio.TestTools.UnitTesting;
using PillarBabysitterKata.Classes;
using System;

namespace BabsitterKataTests
{
    [TestClass]
    public class JobTest
    {
        [TestMethod]
        public void Ctor()
        {
            DateTime jobStartTime = DateTime.Parse("7:00PM");
            DateTime jobEndTime = DateTime.Parse("1:00AM");
            var family = new Family("Test", new RatePeriod[]
            {
                new RatePeriod(DateTime.Parse("6:00 PM"), DateTime.Parse("10:00 PM"), 10.00M),
                new RatePeriod(DateTime.Parse("10:00 PM"), DateTime.Parse("4:00 AM"), 5.00M)
            });
            var job = new Job(jobStartTime, jobEndTime, family);
            Assert.AreEqual(jobStartTime, job.JobStartTime);
            Assert.AreEqual(jobEndTime, job.JobEndTime);
            Assert.AreEqual(family, job.Family);
        }

        [TestMethod]
        public void JobReturnsPayment()
        {
            DateTime jobStartTime = DateTime.Parse("7:00PM");
            DateTime jobEndTime = DateTime.Parse("9:00PM");
            var family = new Family("Test", new RatePeriod[]
            {
                new RatePeriod(DateTime.Parse("6:00 PM"), DateTime.Parse("10:00 PM"), 10.00M),
                new RatePeriod(DateTime.Parse("10:00 PM"), DateTime.Parse("4:00 AM"), 5.00M)
            });
            var job = new Job(jobStartTime, jobEndTime, family);

            Assert.AreEqual(20, job.Payment);
        }

        [TestMethod]
        public void JobCrossesRatePeriods()
        {
            DateTime jobStartTime = DateTime.Parse("7:00PM");
            DateTime jobEndTime = DateTime.Parse("11:00PM");
            var family = new Family("Test", new RatePeriod[]
            {
                new RatePeriod(DateTime.Parse("6:00 PM"), DateTime.Parse("10:00 PM"), 10.00M),
                new RatePeriod(DateTime.Parse("10:00 PM"), DateTime.Parse("4:00 AM"), 5.00M)
            });
            var job = new Job(jobStartTime, jobEndTime, family);

            Assert.AreEqual(35, job.Payment);
        }
    
    }
}

