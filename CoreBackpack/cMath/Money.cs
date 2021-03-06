﻿using System;

namespace CoreBackpack.cMath
{
    public static class MoneyExtender
    {
        public static int ConvertToCents(this decimal amount)
        {
            var change = amount * 100;
            var newchange = Convert.ToInt32(change);
            return newchange;
        }

        public static decimal ConvertToDollars(this int cents)
        {
            decimal dollar = cents * 0.01m;
            return dollar;
        }

        public static decimal ConvertToDollars(this long cents)
        {
            decimal dollar = cents * 0.01m;
            return dollar;
        }
    }
}
