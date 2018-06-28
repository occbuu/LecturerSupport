using System;
using System.Globalization;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentTime = DateTime.Now;
            //.Net
            Console.WriteLine("Full formats");
            Console.WriteLine(currentTime.ToString());
            Console.WriteLine(currentTime.ToString("R"));
            Console.WriteLine();
            Console.WriteLine("Time");
            Console.WriteLine(currentTime.ToLongTimeString()); //have seconds
            Console.WriteLine(currentTime.ToShortTimeString()); //dont have seconds
            Console.WriteLine();
            Console.WriteLine("Date");
            Console.WriteLine(currentTime.ToLongDateString()); //Months is text
            Console.WriteLine(currentTime.ToShortDateString()); //Months is number
            Console.WriteLine();

            //RFC1123
            Console.WriteLine(DateTime.UtcNow.ToString());
            Console.WriteLine(DateTime.UtcNow.ToString("R"));// details
            Console.WriteLine();

            //Formatting by culture 
            //var vietnam = new CultureInfo(1066);
            //Console.WriteLine("VietNam: {0}", currentTime.ToString(vietnam));
            //Console.WriteLine();

            //Parsing Dates
            var date = DateTime.Parse("9/1/2017", new CultureInfo(1066));
            var date2 = DateTime.Parse("9/1/2017", new CultureInfo(1033));
            Console.WriteLine(date.ToLongDateString() + " vs " + date2.ToLongDateString());
        }
    }
}