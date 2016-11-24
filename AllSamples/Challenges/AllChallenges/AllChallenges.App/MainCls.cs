using System;
using AllChallenges.Lib;
using static System.Console;

namespace AllChallenges.App
{
    public class MainCls
    {
        public static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;

            FredoIsInAHurry.Run();

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }
}
