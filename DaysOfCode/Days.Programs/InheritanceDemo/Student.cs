using System.Linq;

namespace Days.Programs.InheritanceDemo
{
    public class Student : Person
    {
        private int[] testScores;

        public Student(string firstName, string lastName, int identification, int[] testScores) : base(firstName, lastName, identification)
        {
            this.testScores = testScores;
        }

        public char Calculate()
        {
            var output = 'T';
            var average = testScores.Sum() / testScores.Length;

            if (average >= 90 && average <= 100)
            {
                output = 'O';
            }
            else if (average >= 80 && average < 90)
            {
                output = 'E';
            }
            else if (average >= 70 && average < 80)
            {
                output = 'A';
            }
            else if (average >= 55 && average < 70)
            {
                output = 'P';
            }
            else if (average >= 40 && average < 55)
            {
                output = 'D';
            }
            return output;
        }
    }
}
