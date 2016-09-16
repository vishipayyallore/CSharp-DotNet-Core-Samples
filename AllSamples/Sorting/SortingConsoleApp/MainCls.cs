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
