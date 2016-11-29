using System;
using static System.Console;

namespace AllChallenges.Lib
{
    public class CompilerVersion
    {

        public static void Run()
        {
            string inputLine;
            while ((inputLine = ReadLine().Trim()) != null)
            {
                var commentIndex = inputLine.IndexOf(@"//", StringComparison.Ordinal);
                inputLine = commentIndex != -1 ? string.Format("{0}{1}", inputLine.Substring(0, commentIndex).Replace("->", "."), inputLine.Substring(commentIndex)) : inputLine.Replace("->", ".");
                WriteLine($"{inputLine}");
            }
        }
    }
}
