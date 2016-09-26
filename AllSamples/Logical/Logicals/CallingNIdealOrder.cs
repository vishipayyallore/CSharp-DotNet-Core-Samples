using System;
using System.Linq;
using CoreResuables;
using static System.Console;

namespace Logicals
{
    public class CallingNIdealOrder : IProgram
    {
        public static void Run()
        {
            WriteLine("Enter the number of Elements:");
            var numberOfElements = int.Parse(ReadLine().Trim());
            var lastIndex = numberOfElements - 1;
            var count = 0;

            WriteLine("Enter Elements for Calling Order:");
            var arrayValues = ReadLine().Trim().Split(' ');
            var callingOrder = arrayValues.Select(int.Parse).ToArray();
            WriteLine("Enter Elements for Ideal Order:");
            arrayValues = ReadLine().Trim().Split(' ');
            var idealOrder = arrayValues.Select(int.Parse).ToArray();


            for (var iCtr = 0; iCtr < numberOfElements; iCtr++)
            {
                for (var jCtr = iCtr; jCtr < numberOfElements; jCtr++)
                {
                    if (idealOrder[iCtr] != callingOrder[iCtr])
                    {
                        var temp = callingOrder[iCtr];
                        Array.Copy(callingOrder, iCtr + 1, callingOrder, iCtr, callingOrder.Length - (iCtr + 1));
                        callingOrder[lastIndex] = temp;
                        count++;
                    }
                    else
                    {
                        count++;
                        break;
                    }

                }
                WriteLine();
            }

            WriteLine($"{count}");

            for (var iCtr = 0; iCtr < numberOfElements; iCtr++)
            {
                WriteLine($" {idealOrder[iCtr]} --- {callingOrder[iCtr]}");
            }
        }
    }
}
