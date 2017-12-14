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
            const int threshold = 40;

            var (average, studentCount, _) = student.GetAverageAndCount(scores, threshold);
            WriteLine($"Average was {average} across {studentCount} students. Below Average: {(average < threshold ? " Class score below average." : " Class score above average.")}");

            WriteLine("\n\nPress any key...");
            ReadKey();
        }
    }
}
