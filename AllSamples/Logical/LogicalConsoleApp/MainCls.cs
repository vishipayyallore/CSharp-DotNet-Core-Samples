using System;
using System.Collections.Generic;
using Logicals;
using CoreResuables;
using static System.Console;

namespace LogicalConsoleApp
{
    public class MainCls
    {
        public static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;
            var programsList = new List<IProgram>()
            {
                new ConsecutiveLetters(),
                new FizzBuzz(),
                new FriendsAndBudget()
            };

            programsList.ForEach(program => program.Run());

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }
}
