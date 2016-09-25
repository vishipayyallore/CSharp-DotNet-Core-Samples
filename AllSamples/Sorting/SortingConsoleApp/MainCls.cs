using System;
using Sortings;
using static System.Console;

namespace SortingConsoleApp
{
    public class MainCls
    {
        //89 76 45 92 67 12 99 | 7 4 5 2 | 4 83 9 6 34 45 | 3 8 7 5 2 1 9 6 4
        public static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;
            
            for (var i = 0; i < 4; i++)
            {
                BubbleSort.Run();

                MergeSort.Run();

                SelectionSort.Run();

                InsertionSort.Run();
            }

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }

    }
}
