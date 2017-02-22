using Days.CoreLibrary;
using static System.Console;

namespace Day1Library
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
