using System;
using System.Linq;
using static System.Console;

namespace SingleDArray
{

    /*
     * SAMPLE INPUT 
        5 2
        1 0 1 1 0
        1 2
        0 1 4
       SAMPLE OUTPUT 
        ODD
     */
    public class BinaryQueries
    {
        public static void Run()
        {
            var firstLineInput = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            var arrayLength = firstLineInput[0];
            var numberOfQueries = firstLineInput[1];

            var arrayValues = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            for (var iCtr = 0; iCtr < numberOfQueries; iCtr++)
            {
                var currentQuery = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                var tempArray = arrayValues;
                var sum = 0.0;
                var jCtr = 0;
                var queryType = currentQuery[0];
                switch (queryType)
                {
                    case 0:
                        jCtr = currentQuery[1] - 1;
                        arrayLength = currentQuery[2] - currentQuery[1] + 1;
                        break;
                    case 1:
                        var indexToChange = currentQuery[1] - 1;
                        tempArray[indexToChange] = 1 - arrayValues[indexToChange];
                        break;
                }

                for (; jCtr < arrayLength; jCtr++)
                {
                    sum += (tempArray[jCtr] * (Math.Pow(2, jCtr)));
                }
                if (currentQuery[0] == 0)
                {
                    WriteLine("{0}", ((sum % 2 == 1) ? "ODD" : "EVEN"));
                }

            }
        }
    }
}
