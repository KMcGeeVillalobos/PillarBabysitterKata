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

            if (jobStartTime > EndTime || jobEndTime < StartTime)
            {
                return 0;
            }
            else if (jobStartTime < StartTime && jobStartTime <= EndTime)
            {
                var timeSpan = jobEndTime - StartTime;
                return timeSpan.TotalHours;
            }
            else if (jobStartTime >= StartTime && jobEndTime > EndTime)
            {
                var timeSpan = EndTime - jobStartTime;
                return timeSpan.TotalHours;
            }
            else
            {
                var timeSpan = jobEndTime - jobStartTime;
                return timeSpan.TotalHours;
            }
        }
    }
}
