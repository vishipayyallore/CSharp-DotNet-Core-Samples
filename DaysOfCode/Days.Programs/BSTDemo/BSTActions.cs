using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Days.Programs.BSTDemo
{
    public class BSTActions
    {

        public static void Run()
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

        static int MaxDepth(Node node) 
        {
            if (node==null) 
                return -1;
            else
            {
                /* compute the depth of each subtree */
                int lDepth = MaxDepth(node.Left);
                int rDepth = MaxDepth(node.Right);
 
                /* use the larger one */
                if (lDepth > rDepth) 
                    return(lDepth+1);
                else
                    return (rDepth+1);
            }
        }

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
