using Days.CoreLibrary;
using Days.Programs.InterfacesDemo;
using static System.Console;

namespace Days.Programs
{
    public class HowToInterfaces : IProgram
    {
        public void Run()
        {
            var number = int.Parse(ReadLine().Trim());
            IAdvancedArithmetic arithmeticCalculator = new CalculatorDivisors();
            var sum = arithmeticCalculator.DivisorSum(number);
            WriteLine($"I implemented: AdvancedArithmetic: {sum}");
        }
    }
}
