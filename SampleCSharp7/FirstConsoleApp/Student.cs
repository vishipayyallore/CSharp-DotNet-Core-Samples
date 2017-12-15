using System.Linq;

namespace FirstConsoleApp
{
    public class Student
    {
        public (double average, int studentCount, bool belowAverage) 
            GetAverageAndCount(int[] scores, int threshold)
        {
            var result = (average:0D, studentCount:0, belowAverage:true);
            result = (((double)scores.Sum()/scores.Length), scores.Length, result.average.CheckIfBelowAverage(threshold));

            return result;
        }

    }

}
