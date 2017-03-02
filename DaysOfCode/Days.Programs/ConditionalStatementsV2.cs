using Days.CoreLibrary;
using static System.Console;

namespace Days.Programs
{
    public class ConditionalStatementsV2 : IProgram
    {
        public void Run()
        {
            var output = string.Empty;
            var number = int.Parse(ReadLine().Trim());
            if (number % 2 == 1)
            {
                output = "Weird";
            }
            else
            {
                output = (number >= 6 && number <= 20) ? "Weird" : "Not Weird";
            }
            WriteLine($"{output}");
        }
    }
}
