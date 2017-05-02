using Days.CoreLibrary;
using static System.Console;

namespace Days.Programs.BSTDemo
{
    public class BSTActions : IProgram
    {

        public void Run()
        {
            Node root = null;
            var numberOfItems = int.Parse(ReadLine());
            while (numberOfItems-- > 0)
            {
                var data = int.Parse(ReadLine());
                root = BSTree.Insert(root, data);
            }
            var height = BSTree.MaxDepth(root);
            WriteLine(height);
        }
        
    }
}
