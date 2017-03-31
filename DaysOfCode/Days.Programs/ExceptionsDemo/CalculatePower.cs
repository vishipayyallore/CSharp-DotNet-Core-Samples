using Days.CoreLibrary;
using System;
using System.Linq;
using static System.Console;

namespace Days.Programs.ExceptionsDemo
{
    public class CalculatePower : IProgram
    {
        private static double power(int n, int p)
        {
            if ((n < 0) || (p < 0))
            {
                throw new Exception($"n and p should be non-negative");
            }
            return Math.Pow(n, p);
        }

        public void Run()
        {
            var numberOfTimes = int.Parse(ReadLine().Trim());
            while (numberOfTimes-- > 0)
            {
                var values = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                if ((values[0] < 0) || (values[1] < 0))
                {
                    WriteLine($"n and p should be non-negative");
                    continue;
                }
                WriteLine($"{Math.Pow(values[0], values[1])}");
            }
        }
    }
}
