using System.Linq;
using static System.Console;

namespace SingleDArray
{
    public class MonksLoveForFood
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

        public static void Run1()
        {
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
                WriteLine((returnValue == null) ? nofood : returnValue.ToString());
            }
        }

        public static void Run()
        {
            const string nofood = "No Food";
            var numberOfQueries = int.Parse(ReadLine().Trim());
            if (numberOfQueries < 1 || numberOfQueries > 100000)
            {
                return;
            }
            var queryArray = new int[numberOfQueries];
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
                queryArray[iCtr] = arrayElements[0];
                if (queryArray[iCtr] != 1) continue;
                var returnValue = Pop(priceArray);
                WriteLine((returnValue == null) ? nofood : returnValue.ToString());
            }
        }
    }
}
