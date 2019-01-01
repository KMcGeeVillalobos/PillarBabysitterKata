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
            StartTime = TimeUtil.AdjustTimesAfterMidnight(startTime);
            EndTime = TimeUtil.AdjustTimesAfterMidnight(endTime);
            Rate = rate;
        }

        public decimal HrsInRatePeriod(DateTime jobStartTime, DateTime jobEndTime)
        {
            jobStartTime = TimeUtil.AdjustTimesAfterMidnight(jobStartTime);
            jobEndTime = TimeUtil.AdjustTimesAfterMidnight(jobEndTime);

            if (jobStartTime > EndTime || jobEndTime < StartTime)
            {
                return 0;
            }
            else if (jobStartTime < StartTime && jobStartTime <= EndTime)
            {
                var timeSpan = jobEndTime - StartTime;
                var decTime =  (decimal)timeSpan.TotalHours;
                return Math.Ceiling(decTime);
            }
            else if (jobStartTime >= StartTime && jobEndTime > EndTime)
            {
                var timeSpan = EndTime - jobStartTime;
                var decTime = (decimal)timeSpan.TotalHours;
                return Math.Ceiling(decTime);
            }
            else
            {
                var timeSpan = jobEndTime - jobStartTime;
                var decTime = (decimal)timeSpan.TotalHours;
                return Math.Ceiling(decTime);
            }
        }

        public decimal CalculatePayment(DateTime jobStartTime, DateTime jobEndTime)
        {
            return HrsInRatePeriod(jobStartTime, jobEndTime) * Rate;
        }
    }
}
