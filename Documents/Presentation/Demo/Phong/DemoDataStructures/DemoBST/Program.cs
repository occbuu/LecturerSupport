namespace DemoBST
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Add(8);
            tree.Add(4);
            tree.Add(2);
            tree.Add(3);
            tree.Add(6);
            tree.Add(7);
            tree.Add(10);
            tree.Add(12);
            tree.Add(9);

            //tree.Add(5);
            //tree.Add(10);
            //tree.Add(2);

            //----To check whether a tree contains an element----//

            //var c = tree.Contains(3);

            //----Delete an elementin the tree----//

            tree.Remove(8);
        }
    }
}