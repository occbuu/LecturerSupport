using System;
using System.Globalization;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = new CultureInfo(1066);
            Console.WriteLine(CultureInfo.CurrentCulture.Name);

            //1066
            //Thread.CurrentThread.CurrentCulture = new CultureInfo(1053);
            //Console.WriteLine(CultureInfo.CurrentCulture.LCID);
            //Console.WriteLine(DateTime.UtcNow.ToString());

            //var number = 22.30;
            //var result = number.ToString(CultureInfo.InvariantCulture);
            //Console.WriteLine(result);
            // Console.ReadLine();

            // RegionInfo
            //var info = new RegionInfo(1066);
            //Console.WriteLine("Hello: {0}", info.EnglishName);
            //Console.WriteLine("I have 100.000 {0}", info.ISOCurrencySymbol);
        }
    }
}