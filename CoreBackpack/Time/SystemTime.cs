using System;

namespace CoreBackpack.Time
{
    public static class SystemTime
    {
        public static DateTimeOffset Now
        {
            get
            {
                return DateTimeOffset.UtcNow;
            }
        }
    }
}