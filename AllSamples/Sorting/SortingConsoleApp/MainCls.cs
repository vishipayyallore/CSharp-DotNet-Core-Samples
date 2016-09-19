using System;
using static System.Console;
using Sortings;

namespace SortingConsoleApp
{
    public class MainCls
    {
        public static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;
            //89 76 45 92 67 12 99 | 7 4 5 2 | 4 83 9 6 34 45 | 3 8 7 5 2 1 9 6 4

            //Bubble Sort
            BubbleSort.Run();

            //Merge Sort
            MergeSort.Run();

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }

        

        

    }
}
