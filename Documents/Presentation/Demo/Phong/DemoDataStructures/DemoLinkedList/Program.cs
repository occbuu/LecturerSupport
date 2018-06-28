using System;

namespace DemoQueue
{
    class SinhVien
    {
        public int ID { set; get; }
        public string Name { set; get; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linked = new LinkedList<int>();
            linked.Add(3);
            linked.Add(5);
            linked.Add(7);

            int a = 5;
            var b = a << 1;

            //----Containing many type elements---//

            //LinkedList<SinhVien> linked = new LinkedList<SinhVien>();
            //SinhVien sv1 = new SinhVien();
            //sv1.ID = 1311060953;
            //sv1.Name = "Huynh Minh Phong";
            //linked.Add(sv1);
            //sv1.ID = 1311060953;
            //sv1.Name = "Huynh Minh Phi";
            //linked.Add(sv1);

            //----Contains method----//

            //var checkContain = linked.Contains(3);
            //if (checkContain)
            //{
            //    Console.WriteLine("Found!");
            //}
            //else
            //{
            //    Console.WriteLine("Not Found!");
            //}

            //----Get linked list----//
            // For a single type

            //foreach (var item in linked.GetLinkedList())
            //{
            //    Console.Write(item+"\t");
            //}

            // For multiple types
            //foreach (var item in linked.GetLinkedList())
            //{
            //    Console.Write(item.ID + "\n");
            //    Console.Write(item.Name + "\n");
            //}

            //----Clear----//

            //linked.Clear();

            //----Remove a element----//

            //var checkRemove = linked.Remove(3);
            //if (checkRemove)
            //{
            //    Console.WriteLine("Deleted!");
            //}
            //else
            //{
            //    Console.WriteLine("Cant delete");
            //}

            Console.ReadLine();
        }
    }
}