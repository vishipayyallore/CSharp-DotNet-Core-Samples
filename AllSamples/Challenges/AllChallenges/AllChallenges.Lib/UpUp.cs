using System.Text;
using static System.Console;

namespace AllChallenges.Lib
{
    public class UpUp
    {
        public static void Run()
        {
            var input = ReadLine().Trim();
            var output = new StringBuilder(1024);
            foreach (var currentWord in input.Split(' '))
            {
                if (currentWord.Length < 2)
                {
                    if (currentWord.Length == 0)
                    {
                        output.Append($" ");
                        continue;
                    }
                    output.Append($"{char.ToUpper(currentWord[0])} ");
                    continue;
                }
                output.Append($"{char.ToUpper(currentWord[0])}{currentWord.Substring(1)} ");
            }
            WriteLine($"{output}");
        }
    }
}
