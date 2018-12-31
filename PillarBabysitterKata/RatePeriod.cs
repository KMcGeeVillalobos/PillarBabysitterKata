using System;
namespace PillarBabysitterKata.Classes
{
    public class RatePeriod
    {
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }
        public decimal Rate { get; private set; }

        private DateTime AdjustTimesAfterMidnight(DateTime time) {
            if(time >= DateTime.Parse("12:00AM") && time <= DateTime.Parse("4:00AM"))
            {
                return time + new TimeSpan(1,0,0,0);
            }
            else
            {
                return time;
            }
        }

        public RatePeriod(DateTime startTime, DateTime endTime, decimal rate)
        {
            StartTime = AdjustTimesAfterMidnight(startTime);
            EndTime = AdjustTimesAfterMidnight(endTime);
            Rate = rate;
        }

        public decimal HrsInRatePeriod(DateTime jobStartTime, DateTime jobEndTime)
        {
            jobStartTime = AdjustTimesAfterMidnight(jobStartTime);
            jobEndTime = AdjustTimesAfterMidnight(jobEndTime);

            if (jobStartTime > EndTime || jobEndTime < StartTime)
            {
                return 0;
            }
            else if (jobStartTime < StartTime && jobStartTime <= EndTime)
            {
                var timeSpan = jobEndTime - StartTime;
                return (decimal)timeSpan.TotalHours;
            }
            else if (jobStartTime >= StartTime && jobEndTime > EndTime)
            {
                var timeSpan = EndTime - jobStartTime;
                return (decimal)timeSpan.TotalHours;
            }
            else
            {
                var timeSpan = jobEndTime - jobStartTime;
                return (decimal)timeSpan.TotalHours;
            }
        }

        public decimal CalculatePayment(DateTime jobStartTime, DateTime jobEndTime)
        {
            return HrsInRatePeriod(jobStartTime, jobEndTime) * Rate;
        }
    }
}
