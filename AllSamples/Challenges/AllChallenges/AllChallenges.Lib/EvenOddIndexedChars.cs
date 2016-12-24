using static System.Console;

namespace AllChallenges.Lib
{
    public class EvenOddIndexedChars
    {
        public static void Run()
        {
            var numberOfItems = int.Parse(ReadLine().Trim());
            while (numberOfItems-- > 0)
            {
                var input = ReadLine().Trim();
                for (var iCtr = 0; iCtr < input.Length; iCtr += 2)
                {
                    Write($"{input[iCtr]}");
                }
                Write($" ");
                for (var iCtr = 1; iCtr < input.Length; iCtr += 2)
                {
                    Write($"{input[iCtr]}");
                }
                WriteLine();
            }
        }
    }
}
