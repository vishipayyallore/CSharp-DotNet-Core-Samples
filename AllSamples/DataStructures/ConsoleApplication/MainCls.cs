using System;
using System.Linq;
using SingleDArray;
using static System.Console;
using TwoDArray;

namespace DataStructureConsoleApp
{

    public class MainCls
    {

        private static void Push(int?[] tempArray, int number)
        {
            for (var iCtr = tempArray.Length - 1; iCtr > 0; iCtr--)
            {
                if (tempArray[iCtr - 1] == null) continue;
                tempArray[iCtr] = tempArray[iCtr - 1];
            }
            tempArray[0] = number;
        }

        private static int? Pop(int?[] tempArray)
        {
            var output = tempArray[0];
            if (output == null) return null;
            for (var iCtr = 0; iCtr < tempArray.Length - 2; iCtr++)
            {
                if (tempArray[iCtr] == null) break;
                tempArray[iCtr] = tempArray[iCtr + 1];
            }
            return output;
        }

        public static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;

            var numberOfRepitations = int.Parse(ReadLine().Trim());
            for (; numberOfRepitations > 0; numberOfRepitations--)
            {
                var numberOfCars = int.Parse(ReadLine().Trim());
                var carSpeeds = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

                var count = 1;
                var minimumValue = carSpeeds[0];
                for (var iCtr = 1; iCtr < numberOfCars; iCtr++)
                {
                    if (minimumValue < carSpeeds[iCtr]) continue;
                    count++;
                    minimumValue = carSpeeds[iCtr];
                }
                WriteLine($"{count}");
            }

            //Speed Of Cars
            //var carSpeeds = new int[] {8, 5, 9};
            //{ 1, 1, 1, 1 };
            //{4, 5, 1, 2, 3};
            //{8, 3, 6};
            //{3, 1, 3, 4, 2};
            //{ 55, 2, 4, 3, 5, 1, 12, 13, 67, 87 }; 
            //{4, 5, 1, 2, 3};
            //var count = 1;
            //var minimum = carSpeeds[0];
            //for (var iCtr = 1; iCtr < carSpeeds.Length; iCtr++)
            //{
            //    if (carSpeeds[iCtr] > minimum) continue;
            //    ++count;
            //    minimum = carSpeeds[iCtr];
            //}
            //WriteLine($"Count: {count}");

            //MonksLoveForFood
            const string nofood = "No Food";
            var numberOfQueries = int.Parse(ReadLine().Trim());
            if (numberOfQueries < 1 || numberOfQueries > 100000)
            {
                return;
            }
            var priceArray = new int?[numberOfQueries];

            for (var iCtr = 0; iCtr < numberOfQueries; iCtr++)
            {
                var arrayElements = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                if (arrayElements.Length == 2)
                {
                    if (arrayElements[1] < 1 || arrayElements[1] > 10000000)
                    {
                        iCtr--;
                        continue;
                    }
                    Push(priceArray, arrayElements[1]);
                }
                if (arrayElements[0] != 1) continue;
                var returnValue = Pop(priceArray);
                WriteLine((returnValue == null) ? nofood : string.Format("{0}", returnValue));
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
