using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace BasicsofImplementation.Lib
{
    public class Printhackerearth
    {
        #region Methods.
        public static void Run()
        {
            var baseCounts = new Dictionary<char, int>
            {
                {'h', 2 },{'a', 2 },{'c', 1 },{'k', 1 },{'e', 2 },{'r', 2 },{'t', 1 }
            };
            var dataCounts = new Dictionary<char, int>
            {
                {'h', 0 },{'a', 0 },{'c', 0 },{'k', 0 },{'e', 0 },{'r', 0 },{'t', 0 }
            };

            var numberOfCharacters = int.Parse(ReadLine().Trim());
            var data = ReadLine().Trim();
            foreach (var digit in data)
            {
                if (!dataCounts.ContainsKey(digit))
                {
                    dataCounts.Add(digit, 1);
                }
                else
                {
                    dataCounts[digit] += 1;
                }
            }

            var count = 1;
            var exitLoop = false;
            while (!exitLoop)
            {
                if (baseCounts.Any(keyValuePair => dataCounts[keyValuePair.Key] < (keyValuePair.Value * count)))
                {
                    exitLoop = true;
                }
                if (!exitLoop) { count++; }
            }

            WriteLine($"{--count}");
        }
        #endregion
    }
}
