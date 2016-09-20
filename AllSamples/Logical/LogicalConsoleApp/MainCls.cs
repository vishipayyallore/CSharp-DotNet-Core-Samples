using System;
using static System.Console;

namespace LogicalConsoleApp
{
    public class MainCls
    {
        public static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }
}
