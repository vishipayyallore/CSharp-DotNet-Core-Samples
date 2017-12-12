using System.Linq;

namespace FirstConsoleApp
{
    public class Student
    {
        public (int average, int studentCount) GetAverageAndCount(int[] scores)
        {
            (int average, int studentCount) result;
            result = (result.average = (scores.Sum()/scores.Length), result.studentCount = scores.Length);

            return result;
        }

    }

}
