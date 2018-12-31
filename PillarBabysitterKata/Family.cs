using System;

namespace PillarBabysitterKata.Classes
{
    public class Family
    {
        public string Name { get; private set; }
        public RatePeriod[] RatePeriods { get; private set; }

        public Family(string name, RatePeriod[] ratePeriods)
        {
            Name = name;
            RatePeriods = ratePeriods;
        }

        public static readonly Family FamilyA = new Family("A", new RatePeriod[]
        {
            new RatePeriod(DateTime.Parse("5:00 PM"), DateTime.Parse("11:00 PM"), 15.00M),
            new RatePeriod(DateTime.Parse("11:00 PM"), DateTime.Parse("4:00 AM"), 20.00M)
        });
        public static readonly Family FamilyB = new Family("B", new RatePeriod[]
        {
            new RatePeriod(DateTime.Parse("5:00 PM"), DateTime.Parse("10:00 PM"), 12.00M),
            new RatePeriod(DateTime.Parse("10:00 PM"), DateTime.Parse("12:00 AM"), 8.00M),
            new RatePeriod(DateTime.Parse("12:00 AM"), DateTime.Parse("4:00 AM"), 16.00M)
        });
        public static readonly Family FamilyC = new Family("C", new RatePeriod[]
        {
            new RatePeriod(DateTime.Parse("5:00 PM"), DateTime.Parse("9:00 PM"), 21.00M),
            new RatePeriod(DateTime.Parse("9:00 PM"), DateTime.Parse("4:00 AM"), 15.00M)
        });
    }
}

