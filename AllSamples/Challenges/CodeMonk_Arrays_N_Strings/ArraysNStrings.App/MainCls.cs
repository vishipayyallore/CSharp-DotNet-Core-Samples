using System;
using System.Collections.Generic;
using System.Linq;
using ArraysNStrings.Lib;
using static System.ConsoleColor;
using static System.Console;

namespace ArraysNStrings.App
{
    public class MainCls
    {
        public static void Main(string[] args)
        {
            ForegroundColor = Cyan;

            var numberOfTestCases = int.Parse(ReadLine().Trim());
            for ( ; numberOfTestCases > 0; numberOfTestCases--)
            {
                var count = new Dictionary<string, int>();
                var arrayDimension = int.Parse(ReadLine().Trim());
                var arrayElements = new int[arrayDimension, arrayDimension];
                for (var iCtr = 0; iCtr < arrayDimension; iCtr++)
                {
                    var currentRow = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                    Buffer.BlockCopy(currentRow, 0, arrayElements, iCtr*arrayDimension*sizeof (int), arrayDimension* sizeof(int));
                }

                for (var iCtr = 0; iCtr < arrayDimension-1; iCtr++)
                {
                    for (var jCtr = 0; jCtr < arrayDimension-1; jCtr++)
                    {
                        if (arrayElements[iCtr, jCtr] > arrayElements[iCtr, (jCtr + 1)])
                        {
                            count[$"{iCtr},{jCtr} {iCtr},{jCtr + 1}"] = 1;
                        }
                        if (arrayElements[iCtr, jCtr] > arrayElements[iCtr+1, jCtr])
                        {
                            count[$"{iCtr},{jCtr} {iCtr + 1},{jCtr}"] = 1;
                        }
                    }
                }
                WriteLine($"{count}");
            }

            Palindrome.Run();

            Welcome.Run();

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }
}
