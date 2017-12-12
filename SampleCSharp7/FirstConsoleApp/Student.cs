using System.Linq;

namespace FirstConsoleApp
{
    public class Student
    {
        public (int average, int studentCount) GetAverageAndCount(int[] scores)
        {
            (int average, int studentCount) result;
            result = ((scores.Sum()/scores.Length), scores.Length);

            return result;
        }

    }

}
