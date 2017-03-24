using Days.CoreLibrary;
using static System.Console;

namespace Basic.Programs
{
    public class IsPrime1ToN : IProgram
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
