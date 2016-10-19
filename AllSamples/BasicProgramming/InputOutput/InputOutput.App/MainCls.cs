using System;
using InputOutput.Lib;
using static System.Console;

namespace InputOutput.App
{
    public class MainCls
    {
        public static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;

            ToggleString.Run();

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }
}
