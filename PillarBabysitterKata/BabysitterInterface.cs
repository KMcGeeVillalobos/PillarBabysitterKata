using System;
using PillarBabysitterKata.Classes;
namespace PillarBabysitterKata
{
    public class BabysitterInterface
    {
        public void RunInterface()
        {
            DateTime jobStartTime = DateTime.Parse("6:00AM");
            DateTime jobEndTime = DateTime.Parse("6:00AM");
            while (!TimeChecker(jobStartTime, jobEndTime))
            {
                Console.WriteLine("Please enter job start time:");
                jobStartTime = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Please enter job end time:");
                jobEndTime = DateTime.Parse(Console.ReadLine());
            }
            Family family = null;
            while (family == null)
            {
                Console.WriteLine("Please enter family (A, B, or C)");
                string familyInput = (Console.ReadLine());
                family = GetFamily(familyInput);
            }
            var job = new Job(jobStartTime, jobEndTime, family);
            Console.WriteLine($"Your payment will be ${job.Payment}.");
        }

        public Family GetFamily(string familyInput)
        {
            switch (familyInput)
            {
                case "A":
                    return Family.FamilyA;
                case "B":
                    return Family.FamilyB;
                case "C":
                    return Family.FamilyC;
                default:
                    Console.WriteLine("Please enter a valid input.");
                    Console.WriteLine();
                    return null;
            }
        }

        public bool TimeChecker(DateTime jobStartTime, DateTime jobEndTime)
        {
            jobStartTime = TimeUtil.AdjustTimesAfterMidnight(jobStartTime);
            jobEndTime = TimeUtil.AdjustTimesAfterMidnight(jobEndTime);
            var validStartTime = TimeUtil.AdjustTimesAfterMidnight(DateTime.Parse("5:00PM"));
            var validEndTime = TimeUtil.AdjustTimesAfterMidnight(DateTime.Parse("4:00AM"));
            if (jobStartTime >= jobEndTime)
            {
                Console.WriteLine("Please enter a Start Time that is before your End Time.");
                return false;
            }
            else if (jobStartTime < validStartTime)
            {
                Console.WriteLine("Please enter a Start Time that after 5:00PM.");
                return false;
            }
            else if (jobEndTime > validEndTime)
            {
                Console.WriteLine("Please enter an End Time that is before 4:00AM.");
                return false;
            }
            return true;
           
        }
    }
}
