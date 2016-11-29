using System.Linq;
using static System.Console;

namespace AllChallenges.Lib
{
    public class BinaryQueries
    {
        public static void Run()
        {
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
                    var indexToChange = currentQuery[1] - 1;
                    arrayValues[indexToChange] = 1 - arrayValues[indexToChange];
                }
                numberOfQueries--;
            }
        }
    }
}
