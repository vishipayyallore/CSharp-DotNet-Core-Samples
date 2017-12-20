using System;
using static System.Console;
using static System.Math;

namespace FirstConsoleApp
{
    internal static class Program
    {
        private static void Main()
        {
            ForegroundColor = ConsoleColor.Yellow;
            var studentsHelper = new PersonHelper();
            var scores = new[] { 17, 46, 39, 62, 81, 79, 52, 24, 49 };
            const int threshold = 40;

            var (average, studentCount, _) = studentsHelper.GetAverageAndCount(scores, threshold);
            WriteLine($"Average was {Round(average,2)} across {studentCount} students. Below Average: {(average < threshold ? " Class score below average." : " Class score above average.")}");

            WriteLine("\n\nPress any key...");
            ReadKey();
        }
    }
}

