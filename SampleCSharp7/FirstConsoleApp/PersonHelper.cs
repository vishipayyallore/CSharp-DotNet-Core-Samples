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


        public void PrintData(object person)
        {
            if(person is Student)
            {
                var studentObject = (Student) person;
                WriteLine($" Student {studentObject.Name} {studentObject.LastName} is enrolled for courses {string.Join<int>(", ", studentObject.CourseCodes)}");
            }
            if (person is Professor)
            {
                var professorObject = (Professor)person;
                WriteLine($" Student {professorObject.Name} {professorObject.LastName} teaches {string.Join<string>(", ", professorObject.TeachesSubject)}");
            }


        }

    }

}
