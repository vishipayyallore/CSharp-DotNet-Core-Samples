using System.Linq;
using static System.Console;

namespace FirstConsoleApp
{
    public class PersonHelper
    {
        public (double average, int studentCount, bool belowAverage) 
            GetAverageAndCount(int[] scores, int threshold)
        {
            var result = (average:0D, studentCount:0, belowAverage:true);
            result = (((double)scores.Sum()/scores.Length), scores.Length, result.average.CheckIfBelowAverage(threshold));

            return result;
        }

        /// <summary>
        /// Without Pattern Matching
        /// </summary>
        /// <param name="person"></param>
        public void PrintData(object person)
        {
            switch (person)
            {
                case Student _:
                    var studentObject = (Student) person;
                    WriteLine($"\nStudent {studentObject.Name} {studentObject.LastName} is enrolled for courses {string.Join(", ", studentObject.CourseCodes)}");
                    break;
                case Professor _:
                    var professorObject = (Professor)person;
                    WriteLine($"\nProfessor {professorObject.Name} {professorObject.LastName} teaches {string.Join<string>(", ", professorObject.TeachesSubject)}");
                    break;
            }
        }

        /// <summary>
        /// Pattern Matching with "is" keyword
        /// </summary>
        /// <param name="person"></param>
        public void PrintDataWithIsKeyword(object person)
        {
            if (person is null)
            {
                WriteLine($" Object {nameof(person)} is null");
            }

            if (person is Student studentObject)
            {
                WriteLine($"\nStudent {studentObject.Name} {studentObject.LastName} is enrolled for courses {string.Join(", ", studentObject.CourseCodes)}");
            }
            if (person is Professor professorObject)
            {
                WriteLine($"\nProfessor {professorObject.Name} {professorObject.LastName} teaches {string.Join<string>(", ", professorObject.TeachesSubject)}");
            }
        }

        /// <summary>
        /// Pattern Matching with Swtich case
        /// </summary>
        /// <param name="person"></param>
        public void PrintDataWithSwitchCase(object person)
        {
            if (person is null)
            {
                WriteLine($" Object {nameof(person)} is null");
            }

            if (person is Student )
            {
                var studentObject = (Student) person;
                WriteLine($"\nStudent {studentObject.Name} {studentObject.LastName} is enrolled for courses {string.Join(", ", studentObject.CourseCodes)}");
            }
            if (person is Professor )
            {
                var professorObject = (Professor) person;
                WriteLine($"\nProfessor {professorObject.Name} {professorObject.LastName} teaches {string.Join<string>(", ", professorObject.TeachesSubject)}");
            }
        }

    }

}
