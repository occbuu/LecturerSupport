using System;

namespace DemoArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList<int> aList = new ArrayList<int>();
            aList.Add(1);
            aList.Add(2);
            aList.Add(4);
            aList.Add(5);
            aList.Insert(2, 3); // Inserted by index
            //aList.RemoveAt(2); // Removed at a index
            //aList.Remove(1); // Removed by value

            //----Get elements by IEnumerator<T> GetEnumerator() method---//

            //var getEnum = aList.GetEnumerator();
            //while (getEnum.MoveNext())
            //{
            //    Console.WriteLine(getEnum.Current);
            //}

            Console.ReadLine();
        }
    }
}