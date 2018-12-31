using System;
namespace PillarBabysitterKata.Classes
{
    public class RatePeriod
    {
            public DateTime StartTime { get; private set; }
            public DateTime EndTime { get; private set; }
            public decimal Rate { get; private set; }

        public RatePeriod(DateTime startTime, DateTime endTime, decimal rate)
        {
            StartTime = startTime;
            EndTime = endTime;
            Rate = rate;
        }
        public double HrsInRatePeriod(DateTime jobStartTime, DateTime jobEndTime)
        {
            var timeSpan = jobEndTime - jobStartTime;
            return timeSpan.TotalHours;
        }
    }
}
