using CoreBackpack.Geo.US;
using CoreBackpack.Time;
using System;
using System.Threading.Tasks;
using System.Linq;

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

            //var months = DateTimeExtensions.GetMonthsFromToday(6);
            //foreach (var month in months)
            //{
            //    Console.WriteLine(month.Name + " - " + month.MonthNumber.ToString() + " - " + month.StartDate.Year);
            //}


            var test = ConvertUSState.Search("Michigan");

            Console.WriteLine(test.First().Name);

        }
    }
}
