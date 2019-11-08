using System;
using System.Runtime.InteropServices;
using static System.Console;

namespace LinkedList.Demos
{


    public class Node
    {
        public int Value { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var node = new Node { Value = 101 };

            GCHandle handle = GCHandle.Alloc(node, GCHandleType.WeakTrackResurrection);

            IntPtr address = GCHandle.ToIntPtr(handle);

            WriteLine($"Value: {node.Value} at Address: {address}");

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }
}
