using System;

namespace CoreBackpack.Time
{
    public class SystemTime
    {
        public static DateTimeOffset Now
        {
            get
            {
                return DateTimeOffset.UtcNow.LocalDateTime;
            }
        }
    }
}