using System;
using System.Dynamic;
using System.Linq;
using static System.Console;

namespace SortingConsoleApp
{
    public class MainCls
    {
        public static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;

            var arrayElements = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }


        private static void MergeSubArrays(int[] numbers, int left, int mid, int right)
        {
            var tempArray = new int[numbers.Length;

        }

        private static void MergeSort(int[] numbers, int left, int right)
        {
            if (left > right)
            {
                var mid = (left + right) / 2;
                MergeSort(numbers, left, mid);
                MergeSort(numbers, mid, right);

                MergeSubArrays(numbers, left, mid, right);
            }
        }

    }
}
