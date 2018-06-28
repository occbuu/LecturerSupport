namespace DemoSortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            SortingAlgorithms<int> sortAlgorithms = new SortingAlgorithms<int>();
            int[] a = new int[5];
            a[0] = 4;
            a[1] = 1;
            a[2] = 3;
            a[3] = 0;
            a[4] = 5;

            //----Bubble Sort----//

            //sortAlgorithms.BubbleSort(a);

            //----Insert Sort----//
            //sortAlgorithms.InsertSort(a);

            //----Merge Sort----//
            //sortAlgorithms.MergeSort(a);

            //----Quick Sort----//
            sortAlgorithms.Sort(a);
        }
    }
}