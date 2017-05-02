namespace Days.Programs.BSTDemo
{
    public class BSTree
    {
        public static int MaxDepth(Node node)
        {
            if (node == null)
            {
                return -1;
            }
            else
            {
                /* compute the depth of each subtree */
                int lDepth = MaxDepth(node.Left);
                int rDepth = MaxDepth(node.Right);

                /* use the larger one */
                if (lDepth > rDepth)
                {
                    return (lDepth + 1);
                }
                else
                {
                    return (rDepth + 1);
                }
            }
        }

        public static Node Insert(Node root, int data)
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
                    current = Insert(root.Left, data);
                    root.Left = current;
                }
                else
                {
                    current = Insert(root.Right, data);
                    root.Right = current;
                }
                return root;
            }
        }
    }
}
