using System.Linq;
using static System.Console;

namespace CSharp7.Logic.Programs
{
    public class SampleSort
    {

        public void Execute()
        {
            var numberOfItems = int.Parse(ReadLine().Trim());
            var arrayValues = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

        }

    }

}
