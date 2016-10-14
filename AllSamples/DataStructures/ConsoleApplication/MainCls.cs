using System;
using System.Linq;
using SingleDArray;
using static System.Console;

namespace DataStructureConsoleApp
{

    public class MainCls
    {

        public static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;

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

            //MonksLoveForFood
            WriteLine("MonksLoveForFood.cs");
            MonksLoveForFood.Run();

            //Speed of Cars Count
            CarsSpeed.Run();

            ////Two D Array
            //Transpose.Run();

            ////Print SD Array in Reverse
            //var numberOfRepetations = int.Parse(ReadLine().Trim());
            //for ( ; numberOfRepetations>0; numberOfRepetations--)
            //{
            //    var arrayElements = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            //    PrintReverse.Run(arrayElements);
            //}

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }

}
