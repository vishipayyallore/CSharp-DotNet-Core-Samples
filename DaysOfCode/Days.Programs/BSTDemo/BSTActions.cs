using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Days.Programs.BSTDemo
{
    public class BSTActions
    {
        static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node current;
                if (data <= root.data)
                {
                    current = insert(root.Left, data);
                    root.Left = current;
                }
                else
                {
                    current = insert(root.Right, data);
                    root.Right = current;
                }
                return root;
            }
        }
    }
}
