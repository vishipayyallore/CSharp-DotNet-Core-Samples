﻿using System;
using AllChallenges.Lib;
using static System.Console;
using System.Linq;

namespace AllChallenges.App
{


    public class MainCls
    {
        public static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;

            MinMax.Run();
            //var numberOfElements = int.Parse(ReadLine().Trim());
            //var arrayElements = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            //SortMerge(arrayElements, 0, arrayElements.Length - 1);
            //var found = "YES";
            //for (var iCtr = 1; iCtr < arrayElements.Length; iCtr++)
            //{
            //    if (arrayElements[iCtr] - arrayElements[iCtr - 1] < 2) continue;
            //    found = "NO";
            //    break;
            //}
            //WriteLine($"{found}");

            FredoIsInAHurry.Run();

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }

        private static void SortMerge(int[] numbers, int left, int right)
        {
            if (right <= left) return;
            var mid = (left + right) / 2;
            SortMerge(numbers, left, mid);
            SortMerge(numbers, mid + 1, right);

            MergeSubArrays(numbers, left, mid + 1, right);
        }

        private static void MergeSubArrays(int[] numbers, int left, int mid, int right)
        {
            var tempArray = new int[numbers.Length];
            var startPosition = left;
            var leftEnd = mid - 1;
            var numberOfElements = right - left + 1;

            while ((left <= leftEnd) && (mid <= right))
            {
                tempArray[startPosition++] = numbers[left] <= numbers[mid] ? numbers[left++] : numbers[mid++];
            }

            while (left <= leftEnd)
            {
                tempArray[startPosition++] = numbers[left++];
            }

            while (mid <= right)
            {
                tempArray[startPosition++] = numbers[mid++];
            }

            for (var iCtr = 0; iCtr < numberOfElements; iCtr++, right--)
            {
                numbers[right] = tempArray[right];
            }
        }
    }
}
