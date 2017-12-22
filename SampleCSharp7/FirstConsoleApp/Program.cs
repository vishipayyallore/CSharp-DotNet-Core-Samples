using System;
using System.Collections.Generic;
using static System.Console;
using static System.Math;

namespace FirstConsoleApp
{
    internal static class Program
    {
        private static void Main()
        {
            ForegroundColor = ConsoleColor.Yellow;
            var personHelper = new PersonHelper();
            var scores = new[] { 17, 46, 39, 62, 81, 79, 52, 24, 49 };
            const int threshold = 40;

            var (average, studentCount, _) = personHelper.GetAverageAndCount(scores, threshold);
            WriteLine($"Average was {Round(average,2)} across {studentCount} students. Below Average: {(average < threshold ? " Class score below average." : " Class score above average.")}");

            var student = new Student
            {
                Name = "Dirk",
                LastName = "Strauss",
                CourseCodes = new List<int> {203, 202, 101}
            };
            personHelper.PrintData(student);
            personHelper.PrintDataWithIsKeyword(student);
            personHelper.PrintDataWithIsKeyword(null);
            personHelper.PrintDataWithSwitchCase(student);

            var professor = new Professor
            {
                Name = "Reinhardt",
                LastName = "Botha",
                TeachesSubject = new List<string> { "Mobile Development", "Cryptography" }
            };
            personHelper.PrintData(professor);
            personHelper.PrintDataWithIsKeyword(professor);
            personHelper.PrintDataWithIsKeyword(null);
            personHelper.PrintDataWithSwitchCase(professor);

            //Out Parameter Demo
            string value = "500";
            if(int.TryParse(value, out int number))
            {
                WriteLine($"{number} is a valid integer");
            }
            WriteLine($"{number} is a valid integer");

            WriteLine("\n\nPress any key...");
            ReadKey();
        }
    }
}

