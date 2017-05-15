using Programs.Library;
using System;
using static System.Console;

namespace BasicProgramming.App
{
    class ProgramMainClass
    {
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Yellow;

            new ToggleString().Run();

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }
    }
}