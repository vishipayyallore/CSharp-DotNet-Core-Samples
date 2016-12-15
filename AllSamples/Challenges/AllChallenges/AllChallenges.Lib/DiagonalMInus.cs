using System;
using System.Linq;
using static System.Console;

namespace AllChallenges.Lib
{
    public class DiagonalMinus
    {
        public static void Run()
        {
            var leftDiagonal = 0;
            var rightDiagonal = 0;
            var numberOfElements = int.Parse(ReadLine());

            for (var iCtr = 0; iCtr < numberOfElements; iCtr++)
            {
                var arrayValues = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                leftDiagonal += arrayValues[iCtr];
                rightDiagonal += arrayValues[numberOfElements - iCtr - 1];
            }
            WriteLine($"{Math.Abs(leftDiagonal - rightDiagonal)}");
        }
    }
}
