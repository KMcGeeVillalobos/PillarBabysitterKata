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
                var period = Family.RatePeriods[0];
                return period.CalculatePayment(JobStartTime, JobEndTime);
            }
        }
    }
}
