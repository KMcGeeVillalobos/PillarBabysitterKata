using System;
namespace PillarBabysitterKata.Classes
{
    public class Job
    {
        public DateTime JobStartTime { get; set; }
        public DateTime JobEndTime { get; set; }
        public Family Family { get; set; }

        public Job(DateTime jobStartTime, DateTime jobEndTime, Family family)
        {
            JobStartTime = jobStartTime;
            JobEndTime = jobEndTime;
            Family = family;
        }

        public decimal Payment
        {
            get
            {
                decimal total = 0;
                foreach(RatePeriod period in Family.RatePeriods)
                {
                    total += period.CalculatePayment(JobStartTime, JobEndTime);
                }
                return total;
            }
        }
    }
}
