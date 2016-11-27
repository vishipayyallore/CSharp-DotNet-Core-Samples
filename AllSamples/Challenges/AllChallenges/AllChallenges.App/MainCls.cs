using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using AllChallenges.Lib;
using static System.Console;
using System.Linq;
using System.Text;

namespace AllChallenges.App
{


    public class MainCls
    {
        public static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;

            var input = ReadLine().Trim();
            var output = new StringBuilder(1024);
            foreach (var currentWord in input.Split(' '))
            {
                if (currentWord.Length < 2)
                {
                    output.Append($"{char.ToUpper(currentWord[0])} ");
                }
                output.Append($"{char.ToUpper(currentWord[0])}{currentWord.Substring(1)} ");
            }

            WriteLine($"{output}");

            War.Run();

            AdditionAintSimple.Run();

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
