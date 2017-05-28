using BasicProgramming.CoreLibrary;
using static System.Console;

namespace Programs.Library
{
    class Factorial : IProgram
    {
        public void Run()
        {
            WriteLine("Sample Input {5}");
            var number = int.Parse(ReadLine().Trim());
            var factorial = 1;
            while (number > 0)
            {
                factorial *= number;
                number--;
            }
            WriteLine(factorial);
        }
    }
}
