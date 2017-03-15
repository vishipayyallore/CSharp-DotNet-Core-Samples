using Days.CoreLibrary;
using static System.Console;

namespace Days.Programs
{
    public class FactorialDemo : IProgram
    {
        private static int Factorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number -= 1);
            }
        }

        public void Run()
        {
            var number = int.Parse(ReadLine().Trim());
            WriteLine($"{Factorial(number)}");
        }
    }

}
