using BasicProgramming.CoreLibrary;
using System;
using System.Linq;
using static System.Console;

namespace Programs.Library
{
    class FindProduct : IProgram
    {
        #region
        public void Run()
        {
            var numberOfElements = int.Parse(ReadLine().Trim());
            var arrayValues = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            var answer = 1.0;
            var theValue = Math.Pow(10, 9) + 7;
            for (var iCtr = 0; iCtr < numberOfElements; iCtr++)
            {
                answer = (answer * arrayValues[iCtr]) % theValue;
            }
            WriteLine(answer);
        }
        #endregion
    }
}
