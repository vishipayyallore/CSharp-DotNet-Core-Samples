using Days.CoreLibrary;
using static System.Console;

namespace Days.Programs.LinkedListDemo
{

    public class LinkedData : IProgram
    {
        static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Write(start.Data + " ");
                start = start.Next;
            }
        }

        static Node insert(Node head, int data)
        {
            if (head == null)
            {
                head = new Node(data);
            }
            else if (head.Next == null)
            {
                head.Next = new Node(data);
            }
            else
            {
                insert(head.Next, data);
            }

            return head;
        }

        public void Run()
        {
            Node head = null;
            int T = int.Parse(ReadLine().Trim());
            while (T-- > 0)
            {
                int data = int.Parse(ReadLine().Trim());
                head = insert(head, data);
            }
            display(head);
        }
    }

}
