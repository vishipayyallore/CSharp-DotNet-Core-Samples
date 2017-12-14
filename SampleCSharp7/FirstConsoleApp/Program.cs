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

            var (average, studentCount, belowAverage) = student.GetAverageAndCount(scores, 51);
            WriteLine($"Average was {average} across {studentCount} students.");

            WriteLine("\n\nPress any key...");
            ReadKey();
        }
    }
}
