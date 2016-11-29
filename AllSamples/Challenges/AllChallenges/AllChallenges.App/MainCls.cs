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
            var inputLine = string.Empty;
            while ((inputLine = ReadLine().Trim()) != null)
            {
                // Do whatever you want here with line
                var words = inputLine.Replace("//", "/").Split('/');
            }

            //var lineInput = ReadLine().Trim();
            var lineInput = "int t; //variable t";
            
            var output = new StringBuilder(1024);
            foreach (var words in lineInput.Replace("//", "/").Split('/'))
            {
                WriteLine($"{words.Length}");
            }
            //foreach (var lineParts in input.Split('\n').Select(currentLine => currentLine.Split("//".ToCharArray())).Where(lineParts => lineParts.Length != 0))
            //{
            //    output.Append((lineParts.Length == 1) ? lineParts[0] : string.Format("{0} //{1}", lineParts[0].Replace("->", "."), lineParts[1]));
            //}
            WriteLine($"{output}");

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
