using System.Linq;
using static System.Console;

namespace AllChallenges.Lib
{
    public class ReverseArray
    {
        public static void Run()
        {
            var numberOfItems = int.Parse(ReadLine().Trim());
            var arrayValues = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            WriteLine(string.Join(" ", arrayValues.Reverse()));
        }
    }
}
