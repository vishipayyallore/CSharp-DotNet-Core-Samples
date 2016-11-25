using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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

            var dataCounts = new Dictionary<char, int>
            {
                {'a', 1 },{'b', 2 },{'c', 3 },{'d', 4 },{'e', 5 },{'f', 6 },{'g', 7 },{'h', 8 },{'i', 9 },
                {'j', 10 },{'k', 11 },{'l', 12 },{'m', 13 },{'n', 14 },{'o', 15 },{'p', 16 },{'q', 17 },{'r', 18 },
                {'s', 19 },{'t', 20 },{'u', 21 },{'v', 22 },{'w', 23 },{'x', 24 },{'y', 25 },{'z', 26 }
            };

            var numberOfRepeats = int.Parse(ReadLine().Trim());

            while (numberOfRepeats > 0)
            {
                var jCtr = 0;
                var data = ReadLine().Trim();
                for (var iCtr = data.Length - 1; iCtr >= 0; iCtr--, jCtr++)
                {
                    var index = dataCounts[data[iCtr]] + dataCounts[data[jCtr]] % 26;
                    //WriteLine($"{dataCounts[data[iCtr]]} {dataCounts[data[jCtr]]} {dataCounts[data[iCtr]] + dataCounts[data[jCtr]]} {dataCounts.FirstOrDefault(v => v.Value == index).Key}"); 
                    Write($"{dataCounts.FirstOrDefault(v => v.Value == index).Key}");
                }
                numberOfRepeats--;
            }
            

            MinMax.Run();

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
