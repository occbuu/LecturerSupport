namespace DemoQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> values = new Queue<int>();
            values.Enqueue(1);
            values.Enqueue(2);
            values.Enqueue(3);
            values.Enqueue(4);
            values.Enqueue(5);
            var a = values.Dequeue();
            var b = values.Peek();
        }
    }
}