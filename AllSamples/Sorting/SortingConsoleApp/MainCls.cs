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

            BubbleSort.Run();

            //var arrayElements = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            var numbers = new[] { 3, 8, 7, 5, 2, 1, 9, 6, 4 };

            WriteLine($"Before: {string.Join(" ", numbers)}");
            MergeSort.Run(numbers, 0, numbers.Length-1);
            WriteLine($"After: {string.Join(" ", numbers)}");

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }

        

        

    }
}
