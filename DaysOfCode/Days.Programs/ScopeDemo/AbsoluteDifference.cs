using Days.CoreLibrary;
using System;
using System.Linq;
using static System.Console;

namespace Days.Programs.ScopeDemo
{
    public class AbsoluteDifference : IProgram
    {

        private int[] arrayElements;
        public int maximumDifference;

        public void Run()
        {
            arrayElements = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            maximumDifference = int.MinValue;

            for (var iCtr = 0; iCtr < arrayElements.Length; iCtr++)
            {
                for (var jCtr = iCtr + 1; jCtr < arrayElements.Length; jCtr++)
                {
                    if (maximumDifference < Math.Abs(arrayElements[iCtr] - arrayElements[jCtr]))
                    {
                        maximumDifference = Math.Abs(arrayElements[iCtr] - arrayElements[jCtr]);
                    }
                }
            }
            WriteLine($"{maximumDifference}");
        }
    }
}
