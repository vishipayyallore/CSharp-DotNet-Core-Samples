using Days.CoreLibrary;
using System.Linq;
using static System.Console;

namespace Days.Programs
{

    public class ArrayDemo : IProgram
    {
        public void Run()
        {
            var numberOfItems = int.Parse(ReadLine().Trim());
            var arrayValues = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            WriteLine(string.Join(" ", arrayValues.Reverse()));
        }
    }

}
