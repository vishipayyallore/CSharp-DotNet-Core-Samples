using LogicPrograms.Interfaces;
using LogicPrograms.Logics;
using static System.Console;

namespace LogicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {

            IMath math = new Math();

            Write("Enter a number for finding Factorial: ");
            var value = ReadLine();

            if (int.TryParse(value, out int number))
            {
                var factorial = math.GetFactorial(number);
                WriteLine($"Factorial: {factorial}");
            }
        }

    }

}
