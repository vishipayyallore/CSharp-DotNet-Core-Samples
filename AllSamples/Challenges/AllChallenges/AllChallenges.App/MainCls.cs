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

            var firstLineInput = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            var arrayLength = firstLineInput[0];
            var numberOfQueries = firstLineInput[1];
            long sum = 0;

            var arrayValues = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            while (numberOfQueries > 0)
            {
                var currentQuery = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

                if (currentQuery[0] == 0)
                {
                    currentQuery[1]--;
                    currentQuery[2]--;
                    var powerValue = 1;
                    for (var kCtr = currentQuery[1]; kCtr < currentQuery[2]; kCtr++)
                    {
                        if (arrayValues[kCtr] == 1)
                        {
                            sum += (arrayValues[kCtr] * powerValue);
                        }
                        powerValue *= 2;
                    }
                    WriteLine("{0}", ((sum % 2 == 0) ? "EVEN" : "ODD"));
                }
                else
                {
                    var indexToChange = currentQuery[1]-1;
                    arrayValues[indexToChange] = 1 - arrayValues[indexToChange];
                }
                numberOfQueries--;
            }

            UpUp.Run();

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
