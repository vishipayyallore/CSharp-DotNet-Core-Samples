using System.Linq;

namespace FirstConsoleApp
{
    public class Student
    {
        public (int average, int studentCount, bool belowAverage) 
            GetAverageAndCount(int[] scores, int threshold)
        {
            (int average, int studentCount, bool belowAverage) result;
            result = ((scores.Sum()/scores.Length), scores.Length, result.average.CheckIfBelowAverage(threshold));

            return result;
        }

    }

}
