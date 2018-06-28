using System;
using System.Globalization;

namespace Currency
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal shoppingCartTotal = 100;
            var us = new CultureInfo("en-US"); Console.WriteLine("Is it {0} ..", shoppingCartTotal.ToString("C0", us));
            var vi = new CultureInfo("vi-VN"); Console.WriteLine(".. or {0}", shoppingCartTotal.ToString("C0", vi));
            //var vi = new RegionInfo("vi-VN"); Console.WriteLine(".. or {0}", shoppingCartTotal.ToString()+vi.ISOCurrencySymbol);
        }
    }
}