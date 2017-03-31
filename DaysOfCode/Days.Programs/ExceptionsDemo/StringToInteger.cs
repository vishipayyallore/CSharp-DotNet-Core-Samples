using Days.CoreLibrary;
using static System.Console;

namespace Days.Programs.ExceptionsDemo
{
    public class StringToInteger : IProgram
    {
        public void Run()
        {
            string data = ReadLine();

            try
            {
                WriteLine($"{int.Parse(data)}");
            }
            catch
            {
                WriteLine($"Bad String");
            }
        }
    }
}
