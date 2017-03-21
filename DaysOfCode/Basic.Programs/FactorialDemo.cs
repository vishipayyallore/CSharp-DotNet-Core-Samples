using static System.Console;
using Days.CoreLibrary;

namespace Basic.Programs
{
    public class FactorialDemo : IProgram
    {
        
        public void Run()
        {
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
