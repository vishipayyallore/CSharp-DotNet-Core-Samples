using System;
using System.Runtime.InteropServices;
using static System.Console;

namespace LinkedList.Demos
{


    public class Node
    {
        public int Value { get; set; }

        public Node NextNode { get; set; }

        public override string ToString()
        {
            GCHandle handle = GCHandle.Alloc(this, GCHandleType.WeakTrackResurrection);
            IntPtr address = GCHandle.ToIntPtr(handle);

            return $"Value: {Value} at Address: {address}";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            var node = new Node { Value = 101 };
            WriteLine(node);

            //GCHandle handle = GCHandle.Alloc(node, GCHandleType.WeakTrackResurrection);

            //IntPtr address = GCHandle.ToIntPtr(handle);

            //WriteLine($"Value: {node.Value} at Address: {address}");

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }
}
