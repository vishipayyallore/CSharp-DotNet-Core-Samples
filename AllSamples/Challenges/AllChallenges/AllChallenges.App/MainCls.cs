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

            var aliceValues = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var bobValues = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var aliceCount = 0;
            var bobCount = 0;

            for (var iCtr = 0; iCtr < aliceValues.Length; iCtr++)
            {
                if (aliceValues[iCtr] == bobValues[iCtr])
                {
                    continue;
                }

                if (aliceValues[iCtr] > bobValues[iCtr])
                {
                    aliceCount++;
                }
                else
                {
                    bobCount++;
                }
            }
            WriteLine($"{aliceCount} {bobCount}");

            var number = Convert.ToInt32(Console.ReadLine());
            var arrayValues2 = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            Console.WriteLine($"{arrayValues2.Sum()}");

            var mealPrice = double.Parse(ReadLine());
            var tipPercent = double.Parse(ReadLine());
            var taxPercent = double.Parse(ReadLine());

            var totalCost = mealPrice + (mealPrice*(tipPercent/100.0)) + (mealPrice*(taxPercent / 100.0));

            WriteLine($"{Math.Round(totalCost)} ");

            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            var value1 = int.Parse(ReadLine());
            var value2 = double.Parse(ReadLine());
            var value3 = ReadLine();

            WriteLine($"{i + value1}");
            WriteLine($"{string.Format("{0:0.0}",(d + value2))}");
            WriteLine($"{s}{value3}");

            var n = Convert.ToInt32(ReadLine());
            var arrayValues1 = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            WriteLine($"{arrayValues1.Sum()}");

            var arrayValues = ReadLine().Trim().Split(' ').ToArray();
            var numberOfDigits = int.Parse(arrayValues[1]);
            var digitValue = Math.Pow(10, numberOfDigits);
            WriteLine($"{digitValue - 1}{arrayValues[0].Substring(numberOfDigits)}");
            //var digitValue = Math.Pow(10, arrayValues[1]);
            //WriteLine($"{arrayValues[0] / digitValue} :: {arrayValues[0] % digitValue}");
            //WriteLine(arrayValues[0] > digitValue ? $"{digitValue - 1}{arrayValues[0]%digitValue}" : $"{digitValue - 1}");


            var inputData = ReadLine().Trim();
            var outputData = new StringBuilder(1024);

            foreach (var currentChar in inputData.ToCharArray().Where(currentChar => outputData.ToString().IndexOf(currentChar) == -1))
            {
                outputData.Append(currentChar);
            }
            WriteLine($"{outputData}");

            CompilerVersion.Run();

            BinaryQueries.Run();  //Not working.

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
