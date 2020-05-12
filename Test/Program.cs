using CoreBackpack.Time;
using System;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //var weeks = DateTimeExtensions.GetWeeks(DateTime.Now.AddDays(-7), DateTime.Now);
            //foreach (var week in weeks)
            //{
            //    Console.WriteLine(week.StartDate.ToString() + " - " + week.EndDate.ToString());
            //}

            var months = DateTimeExtensions.GetMonthsFromToday(3);
            foreach (var month in months)
            {
                Console.WriteLine(month.Name + " - " + month.MonthNumber.ToString());
            }

        }
    }
}
