using System;
using System.Globalization;

namespace Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var vi = new CultureInfo(1066);
            var us = new CultureInfo("en-US");
            var number = 1000000.5;
            Console.WriteLine("VI: {0}", number.ToString("N2", vi));
            Console.WriteLine("US: {0}", number.ToString("N2", us));
        }
    }
}