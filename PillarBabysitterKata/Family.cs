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
    }
}

