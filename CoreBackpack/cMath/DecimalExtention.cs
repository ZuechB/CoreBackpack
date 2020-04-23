using System;
using System.Collections.Generic;
using System.Text;

namespace CoreBackpack.cMath
{
    public static class DecimalExtention
    {
        public static decimal GetDecimalsValues(this decimal number)
        {
            var x = number - Math.Truncate(number);
            return x;
        }

        public static int GetWholeNumber(this decimal number)
        {
            var x = number - Math.Truncate(number);
            var wholeNum = number - x;
            return (int)wholeNum;
        }

        public static decimal PercentOfAmount(decimal percent, decimal amount)
        {
            return Math.Round((percent / 100) * amount, 2, MidpointRounding.AwayFromZero);
        }

        public static decimal Percent(int count, int totalcount)
        {
            return (decimal)((decimal)count / (decimal)totalcount) * 100;
        }

        public static string PercentToString(int count, int totalcount, int roundToDecimal = 2)
        {
            var percent = (decimal)((decimal)count / (decimal)totalcount) * 100;
            return Math.Round(percent, roundToDecimal).ToString() + "%";
        }
    }
}
