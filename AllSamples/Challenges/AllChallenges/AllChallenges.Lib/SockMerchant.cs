using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace AllChallenges.Lib
{
    public class SockMerchant
    {
        public static void Run()
        {
            var numberOfElements = int.Parse(ReadLine());
            var arrayValues = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            var colors = new HashSet<int>();
            var pairs = 0;

            foreach (var arrayValue in arrayValues)
            {
                if (colors.Contains(arrayValue))
                {
                    colors.Remove(arrayValue);
                    pairs++;
                }
                else
                {
                    colors.Add(arrayValue);
                }
            }
            WriteLine($"{pairs}");
        }
    }
}
