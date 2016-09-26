using System;
using System.Collections.Generic;
using static System.Console;

namespace LogicalConsoleApp
{
    public class MainCls
    {
        public static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;
            var programsList = new List<CoreResuables.IProgram>()
            {
                new Logicals.CallingNIdealOrder(),
                new Logicals.ConsecutiveLetters(),
                new Logicals.FizzBuzz(),
                new Logicals.FriendsAndBudget()
            };

            programsList.ForEach(program => program.Run());

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }
}
