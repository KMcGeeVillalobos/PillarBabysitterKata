using Microsoft.VisualStudio.TestTools.UnitTesting;
using PillarBabysitterKata.Classes;
using System;

namespace BabsitterKataTests
{
    [TestClass]
    public class FamilyTest
    {
        [TestMethod]
        public void Ctor()
        {
            string name = "Test Family";
            RatePeriod[] ratePeriods = new RatePeriod[]
            {
                new RatePeriod(DateTime.Parse("8:00PM"), DateTime.Parse("1:00AM"), 10.00M )

            };
            var family = new Family(name, ratePeriods);
            Assert.AreEqual(name, family.Name);
            Assert.AreEqual(ratePeriods, family.RatePeriods);
        }
    }
}

