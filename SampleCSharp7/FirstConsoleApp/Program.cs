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

            // Using Deconstruct [As Extension Method]
            var (firstName, surname) = student;
            WriteLine($"[Deconstruct -> As Extension Method] The student name is {firstName} {surname}");

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

            //Out Variables V1 Demo
            const string value = "500";
            if(int.TryParse(value, out int number))
            {
                WriteLine($"{number} is a valid integer");
            }
            WriteLine($"{number} is a valid integer");

            //Out Variables V2 Demo (Type inference)
            const string value1 = "1500";
            if (int.TryParse(value1, out var number1))
            {
                WriteLine($"{number1} is a valid integer");
            }

            //Extension Method, Tuple, and out variables.
            const string value2 = "500A";
            var (originalValue, number2, isInteger) = value2.ToInt();
            WriteLine(isInteger ? $"{number2} is a valid integer" : $"{originalValue} is NOT a valid integer");

            var studentV2 = new StudentV2("S20323742");
            var (firstNameV2, surName) = studentV2;
            WriteLine($"The student V2 name is {firstNameV2} {surName}");

            WriteLine("\n\nPress any key...");
            ReadKey();
        }
    }
}

