using System;
using static System.Console;
using Logicals;

namespace LogicalConsoleApp
{
    public class MainCls
    {
        public static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;

            FizzBuzz.Run();

            FriendsAndBudget.Run();

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }
}
