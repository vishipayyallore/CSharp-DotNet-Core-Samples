using System;
using static System.Console;

namespace LinkedList.Demos
{

    class Program
    {
        static void Main(string[] args)
        {

            DisplayMonths();

            var node = new Node { Value = 101 };
            WriteLine(node);

            node.NextNode = new Node { Value = 102 };
            WriteLine(node.NextNode);

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }


        private static void DisplayMonths()
        {
            for(var month=1; month <=12; month++)
            {
                WriteLine($"{month}. {new DateTime(DateTime.Now.Year, month, 1).ToString("MMMM")}");
            }
        }

    }
}

//GCHandle handle = GCHandle.Alloc(node, GCHandleType.WeakTrackResurrection);
//IntPtr address = GCHandle.ToIntPtr(handle);
//WriteLine($"Value: {node.Value} at Address: {address}");

