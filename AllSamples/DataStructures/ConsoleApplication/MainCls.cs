using System;
using System.Linq;
using SingleDArray;
using static System.Console;
using TwoDArray;

namespace DataStructureConsoleApp
{

    public class MainCls
    {
        public static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;

            const string nofood = "No Food";
            var numberOfPrices = 0;
            var numberOfQueries = int.Parse(ReadLine().Trim());
            if (numberOfQueries < 1 || numberOfQueries > 100000)
            {
                return;
            }
            var queryArray = new int[numberOfQueries];
            var onlyPrices = new int?[numberOfQueries];
            var priceArray = new int?[numberOfQueries];
            
            for (var iCtr = 0; iCtr < numberOfQueries; iCtr++)
            {
                var arrayElements = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                queryArray[iCtr] = arrayElements[0];
                if (arrayElements.Length != 2) continue;
                onlyPrices[numberOfPrices] = arrayElements[1];
                if (onlyPrices[numberOfPrices] < 1 || onlyPrices[numberOfPrices] > 10000000)
                {
                    iCtr--;
                }
                numberOfPrices++;
            }

            var currentPosition = numberOfPrices - 1;
            for (var iCtr = 0; iCtr < numberOfQueries; iCtr++)
            {
                if (currentPosition <= -1)
                {
                    continue;
                }
                priceArray[iCtr] = (queryArray[iCtr] == 1) ? -1 : onlyPrices[currentPosition--];
                
            }

            currentPosition = 0;
            for (var iCtr = 0; iCtr < numberOfQueries; iCtr++)
            {
                if (queryArray[iCtr] != 1) continue;
                WriteLine(priceArray[currentPosition] == -1 ? nofood : $"{priceArray[currentPosition]}");
                currentPosition++;
            }

            //Two D Array
            Transpose.Run();

            //Print SD Array in Reverse
            var numberOfRepetations = int.Parse(ReadLine().Trim());
            for ( ; numberOfRepetations>0; numberOfRepetations--)
            {
                var arrayElements = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                PrintReverse.Run(arrayElements);
            }

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }

}
