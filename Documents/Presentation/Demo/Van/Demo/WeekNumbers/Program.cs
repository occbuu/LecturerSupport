using System;
using System.Globalization;
using System.Threading;

namespace WeekNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var theDate = new DateTime(2012, 1, 1);

            Thread.CurrentThread.CurrentCulture = new CultureInfo("sv-SE");
            var canlendar = CultureInfo.CurrentCulture.Calendar;
            var formatRules = CultureInfo.CurrentCulture.DateTimeFormat;
            var week = canlendar.GetWeekOfYear(theDate, formatRules.CalendarWeekRule, formatRules.FirstDayOfWeek);
            Console.WriteLine("VN week: " + week);
        }
    }
}