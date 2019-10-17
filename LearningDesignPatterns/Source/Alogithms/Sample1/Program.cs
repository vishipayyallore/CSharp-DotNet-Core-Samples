using System;
using System.Numerics;

namespace Sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger bigInteger = new BigInteger(double.MaxValue);

            var output = GetFactorial(30);
            Console.WriteLine($"Factorial: {output}");

            Console.ReadLine();
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
