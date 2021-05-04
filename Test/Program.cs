using CoreBackpack.Geo.US;
using CoreBackpack.Time;
using System;
using System.Threading.Tasks;
using System.Linq;
using CoreBackpack.Notifications;
using CoreBackpack.Geo;

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


            //var test = ConvertUSState.Search("Michigan");

            //Console.WriteLine(test.First().Name);


            var coord = new Coordinates();
            var distance = coord.GetDistance(36.0230407714844, -78.9084014892578, 37.4191589355469, -122.075408935547);
            Console.WriteLine(distance);

        }
    }
}
