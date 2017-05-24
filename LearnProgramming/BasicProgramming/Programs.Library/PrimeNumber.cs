using BasicProgramming.CoreLibrary;
using static System.Console;

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
            WriteLine("Sample Input {9}. Display all Prime Numbers.");
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
