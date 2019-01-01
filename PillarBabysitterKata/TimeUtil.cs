using System;
namespace PillarBabysitterKata
{
    public static class TimeUtil
    {
        public static DateTime AdjustTimesAfterMidnight(DateTime time)
        {
            if (time >= DateTime.Parse("12:00AM") && time <= DateTime.Parse("4:00AM"))
            {
                return time + new TimeSpan(1, 0, 0, 0);
            }
            else
            {
                return time;
            }
        }
    }
}
