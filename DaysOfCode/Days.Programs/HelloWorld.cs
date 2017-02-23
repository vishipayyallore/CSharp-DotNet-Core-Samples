using Days.CoreLibrary;
using static System.Console;

namespace Days.Programs
{
    public class HelloWorld : IProgram
    {
        public void Run()
        {
            var input = ReadLine();

            WriteLine($"Hello, World.\n{input}");
        }
    }
}
