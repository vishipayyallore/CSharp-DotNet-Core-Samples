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

            var numberOfRepeats = int.Parse(ReadLine().Trim());
            while (numberOfRepeats > 0)
            {
                var numberOfSoldiers = int.Parse(ReadLine().Trim());
                var bobsArmy = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                var alicesArmy = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                var bobsArmyCount = 0;
                var alicesArmyCount = 0;
                for (var iCtr = 0; iCtr < numberOfSoldiers; iCtr++)
                {
                    if (bobsArmy[iCtr] >= bobsArmyCount)
                    {
                        bobsArmyCount = bobsArmy[iCtr];
                    }
                    if (alicesArmy[iCtr] >= alicesArmyCount)
                    {
                        alicesArmyCount = alicesArmy[iCtr];
                    }
                }

                var output = (bobsArmyCount == alicesArmyCount)
                    ? "Tie"
                    : (bobsArmyCount > alicesArmyCount) ? "Bob" : "Alice";
                WriteLine($"{output}");
                numberOfRepeats--;
            }

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
