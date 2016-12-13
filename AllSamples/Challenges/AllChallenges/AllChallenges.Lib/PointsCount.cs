using System;
using System.Linq;
using static System.Console;

namespace AllChallenges.Lib
{

    public class PointsCount
    {
        public static void Run()
        {
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
        }
    }

}
