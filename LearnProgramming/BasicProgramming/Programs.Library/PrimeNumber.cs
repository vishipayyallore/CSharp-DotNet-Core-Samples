using BasicProgramming.CoreLibrary;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace Programs.Library
{
    class PrimeNumber : IProgram
    {
        private static bool IsPrime(int number)
        {
            var iCtr = 2;
            while (iCtr < number)
            {
                if (number % iCtr == 0)
                {
                    break;
                }
                iCtr++;
            }
            return (iCtr == number) ? true : false;
        }

        public void Run()
        {
            var number = int.Parse(ReadLine().Trim());
            var iCtr = 2;
            while (iCtr <= number)
            {
                if (IsPrime(iCtr))
                {
                    Write($"{iCtr} ");
                }
                iCtr++;
            }
        }
    }
}
