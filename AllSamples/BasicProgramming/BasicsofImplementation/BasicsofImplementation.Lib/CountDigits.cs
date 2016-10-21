using System.Collections.Generic;
using static System.Console;

namespace BasicsofImplementation.Lib
{
    public class CountDigits
    {
        #region Methods.
        public static void Run()
        {
            var digitCounts = new Dictionary<char, int>
            {
                {'0', 0 },{'1', 0 },{'2', 0 },{'3', 0 },{'4', 0 },{'5', 0 },{'6', 0 },{'7', 0 },{'8', 0 },{'9', 0 }
            };

            var data = ReadLine().Trim();
            foreach (var digit in data)
            {
                digitCounts[digit] += 1;
            }

            foreach (var keyValuePair in digitCounts)
            {
                WriteLine($"{keyValuePair.Key} {keyValuePair.Value}");
            }
        }
        #endregion
    }
}
