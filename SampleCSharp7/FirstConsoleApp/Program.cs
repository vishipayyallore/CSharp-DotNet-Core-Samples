using System;
using static System.Console;

namespace FirstConsoleApp
{
    static class Program
    {
        private static void Main()
        {
            ForegroundColor = ConsoleColor.Yellow;
            var student = new Student();
            var scores = new[] {17, 46, 39, 62, 81, 79, 52, 24};

            var studentsResult = student.GetAverageAndCount(scores);
            WriteLine($"Average was {studentsResult.average} across {studentsResult.studentCount}");

            WriteLine("\n\nPress any key...");
            ReadKey();
        }
    }
}
