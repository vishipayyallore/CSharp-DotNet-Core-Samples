using System.Linq;
using static System.Console;

namespace AllChallenges.Lib
{
    public class MinSumMaxSum
    {
        public static void Run()
        {
            var arrayValues = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            var minValue = arrayValues[0];
            var maxValue = arrayValues[0];
            var sum = 0;

            foreach (var arrayValue in arrayValues)
            {
                if (maxValue < arrayValue)
                {
                    maxValue = arrayValue;
                }
                if (minValue > arrayValue)
                {
                    minValue = arrayValue;
                }
                sum += arrayValue;
            }
            WriteLine($"{sum - maxValue} {sum - minValue}");
        }
    }
}
