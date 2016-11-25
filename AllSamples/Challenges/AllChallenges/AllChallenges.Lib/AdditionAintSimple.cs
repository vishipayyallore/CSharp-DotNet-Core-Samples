using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace AllChallenges.Lib
{
    public class AdditionAintSimple
    {
        private static readonly Dictionary<char, int> DataCounts = new Dictionary<char, int>
        {
                {'a', 1 },{'b', 2 },{'c', 3 },{'d', 4 },{'e', 5 },{'f', 6 },{'g', 7 },{'h', 8 },{'i', 9 },
                {'j', 10 },{'k', 11 },{'l', 12 },{'m', 13 },{'n', 14 },{'o', 15 },{'p', 16 },{'q', 17 },{'r', 18 },
                {'s', 19 },{'t', 20 },{'u', 21 },{'v', 22 },{'w', 23 },{'x', 24 },{'y', 25 },{'z', 26 }
        };

        public static void Run()
        {
            var numberOfRepeats = int.Parse(ReadLine().Trim());

            while (numberOfRepeats > 0)
            {
                var jCtr = 0;
                var data = ReadLine().Trim();
                for (var iCtr = data.Length - 1; iCtr >= 0; iCtr--, jCtr++)
                {
                    var index = (DataCounts[data[iCtr]] + DataCounts[data[jCtr]]) % 26;
                    index = (index == 0) ? 26 : index;
                    Write($"{DataCounts.FirstOrDefault(v => v.Value == index).Key}");
                }
                WriteLine();
                numberOfRepeats--;
            }
        }
    }
}
