using System;

namespace Text
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = "b".Equals("B", StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine("Result is: " + result);
            var result1 = "i".Equals("I", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("Result is: " + result1);
        }
    }
}