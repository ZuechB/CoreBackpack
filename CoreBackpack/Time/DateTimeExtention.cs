using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CoreBackpack.Time
{
    public enum ISODayOfWeek
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }
    public static class DateTimeExtensions
    {
        public static DateTime GetFirstDayOfWeek(this DateTime dt, DayOfWeek startOfWeek = DayOfWeek.Monday)
        {
            int diff = dt.DayOfWeek - startOfWeek;
            if (diff < 0)
            {
                diff += 7;
            }
            return dt.AddDays(-1 * diff).Date;
        }

        public static DateTime GetFirstDayOfMonth(this DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, 1);
        }

        public static DateTime GetLastDayOfMonth(this DateTime dt)
        {
            if (dt.Month < 12)
            {
                return new DateTime(dt.Year, dt.Month + 1, 1).AddDays(-1);
            }
            else
            {
                return new DateTime(dt.Year, 12, 1);
            }
        }

        public static ISODayOfWeek ISODayOfWeek(this DateTime dt)
        {
            int val = dt.DayOfWeek == 0 ? 7 : (int)dt.DayOfWeek;
            return (ISODayOfWeek)val;
        }

        public static long GetJavascriptTimestamp(this DateTimeOffset input)
        {
            return GetJavascriptTimestamp(input.DateTime);
        }


        public static long GetJavascriptTimestamp(this DateTime input)
        {
            TimeSpan span = new TimeSpan(DateTime.Parse("1/1/1970").Ticks);
            DateTime time = input.Subtract(span);
            return time.Ticks / 10000;
        }

        public static IEnumerable<DateTime> EachDay(DateTimeOffset from, DateTimeOffset thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }

        public static DateTimeOffset ToLocalTime(this DateTimeOffset input, string timeZone)
        {
            return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(input, timeZone);
        }

        public static string ToLocalString(this DateTimeOffset input, string timeZone = null)
        {
            var datetime = input.ToLocalTime(timeZone).DateTime;
            return datetime.ToString();
        }

        public static int TotalMonths(this DateTime start, DateTime end)
        {
            return (start.Year * 12 + start.Month) - (end.Year * 12 + end.Month);
        }

        public static int TotalMonths(this DateTimeOffset start, DateTimeOffset end)
        {
            return (start.Year * 12 + start.Month) - (end.Year * 12 + end.Month);
        }


        public static DateTimeOffset InTimeZone(this DateTime input, string timezone)
        {
            input = DateTime.SpecifyKind(input, DateTimeKind.Unspecified);
            TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById(timezone);
            TimeSpan offset = tzi.GetUtcOffset(input);
            return new DateTimeOffset(input, offset);
        }

        public static DateTime StartOfDay(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day, 0, 0, 0, 0);
        }

        public static DateTime EndOfDay(this DateTime input)
        {
            return input.Date.AddDays(1).AddTicks(-1);
        }

        public static DateTime LastMonth(this DateTime input)
        {
            return input.Date.AddMonths(-1);
        }

        public static DateTimeOffset StartOfMonth(this DateTimeOffset date)
        {
            return new DateTimeOffset(new DateTime(date.Year, date.Month, 1)).StartOfDay();
        }

        public static DateTimeOffset EndOfMonth(this DateTimeOffset input)
        {
            return input.StartOfMonth().AddMonths(1).AddDays(-1).EndOfDay();
        }

        public static DateTimeOffset AddWeeks(this DateTimeOffset date, int weeks)
        {
            return date.AddDays(weeks * 7);
        }

        public static DateTime AddWeeks(this DateTime date, int weeks)
        {
            return date.AddDays(weeks * 7);
        }

        public static DateTimeOffset StartOfDay(this DateTimeOffset input)
        {
            return new DateTimeOffset(input.Date, input.Offset);
        }

        public static DateTimeOffset EndOfDay(this DateTimeOffset input)
        {
            return new DateTimeOffset(input.Date.AddDays(1).AddTicks(-1), input.Offset);
        }

        public static string GetMonthByName(int month)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);
        }

        public static List<DateTimeFrame> GetWeeks(DateTime Start, DateTime End)
        {
            var weeks = new List<DateTimeFrame>();
            int days = 7;

            DateTime startDate = Start;
            while (true)
            {
                var newDate = Start.AddDays(days);
                if (newDate >= End)
                {
                    if (weeks.Count() > 0)
                    {
                        var daysLeft = -(weeks.Last().EndDate - End).Days;
                        if (daysLeft > 0)
                        {
                            var LastDate = weeks.Last().EndDate.AddDays(daysLeft);
                            weeks.Add(new DateTimeFrame()
                            {
                                StartDate = startDate,
                                EndDate = LastDate
                            });
                        }
                    }
                    else
                    {
                        weeks.Add(new DateTimeFrame()
                        {
                            StartDate = Start,
                            EndDate = End
                        });
                    }

                    break;
                }
                weeks.Add(new DateTimeFrame()
                {
                    StartDate = startDate,
                    EndDate = newDate
                });
                startDate = newDate;
                days += 7;
            }
            return weeks;
        }

        //public static List<DateTimeFrame> GetMonths(DateTime Start, DateTime End)
        //{
        //    var months = new List<DateTimeFrame>();
        //}
    }

    public class DateTimeFrame
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
