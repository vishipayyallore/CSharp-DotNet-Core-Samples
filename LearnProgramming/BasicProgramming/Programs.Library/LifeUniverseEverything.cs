using BasicProgramming.CoreLibrary;
using static System.Console;

namespace Programs.Library
{
    class LifeUniverseEverything : IProgram
    {
        public void Run()
        {
            WriteLine("Stop processing input after reading in the number 42");
            do
            {
                var number = int.Parse(ReadLine().Trim());
                if (number == 42)
                {
                    break;
                }
                WriteLine(number);
            } while (true);
        }
    }
}
