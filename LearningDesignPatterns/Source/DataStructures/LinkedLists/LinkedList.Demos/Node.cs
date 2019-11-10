using System;
using System.Runtime.InteropServices;

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
}
