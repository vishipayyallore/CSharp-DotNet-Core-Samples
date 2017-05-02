using Days.CoreLibrary;
using System;

namespace Days.Programs.BSTDemo
{
    public class BSTActions : IProgram
    {

        public void Run()
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }

            int height = MaxDepth(root);
            Console.WriteLine(height);
        }

        
    }
}
