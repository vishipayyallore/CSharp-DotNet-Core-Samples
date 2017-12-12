using System;
using static System.Console;

namespace FirstConsoleApp
{
    internal static class Program
    {
        private static void Main()
        {
            ForegroundColor = ConsoleColor.Yellow;
            var student = new Student();
            var scores = new[] {17, 46, 39, 62, 81, 79, 52, 24};

            var (average, studentCount) = student.GetAverageAndCount(scores);
            WriteLine($"Average was {average} across {studentCount}");

            WriteLine("\n\nPress any key...");
            ReadKey();
        }
    }
}
