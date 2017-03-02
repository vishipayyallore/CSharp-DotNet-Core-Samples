using Days.CoreLibrary;
using static System.Console;

namespace Days.Programs
{
    public class ConditionalStatementsV1 : IProgram
    {
        public void Run()
        {
            var number = int.Parse(ReadLine());
            var output = "Weird";
            if (number % 2 == 0)
            {
                output = ((number >= 2 && number <= 5) || (number > 20)) ? "Not Weird" : output;
            }
            WriteLine(output);
        }
    }
}
