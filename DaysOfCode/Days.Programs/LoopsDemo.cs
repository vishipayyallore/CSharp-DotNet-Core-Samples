using Days.CoreLibrary;
using static System.Console;

namespace Days.Programs
{
    public class LoopsDemo : IProgram
    {
        public void Run()
        {
            var number = int.Parse(ReadLine().Trim());
            for(var iCtr=1; iCtr <= 10; iCtr++)
            {
                WriteLine($"{number} X {iCtr} = {number * iCtr}");
            }
        }
    }
}
