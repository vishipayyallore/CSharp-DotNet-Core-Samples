using System.Numerics;
using static System.Console;

namespace LogicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {

            Write("Enter a number for finding Factorial: ");
            var value = ReadLine();

            if (int.TryParse(value, out int number))
            {
                var factorial = GetFactorial(number);
                WriteLine($"Factorial: {factorial}");
            }
        }

        private static BigInteger GetFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            return number * GetFactorial(number - 1);
        }

    }

}
