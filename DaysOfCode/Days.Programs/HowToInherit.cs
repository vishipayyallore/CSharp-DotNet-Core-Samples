using Days.CoreLibrary;
using Days.Programs.InheritanceDemo;
using System.Linq;
using static System.Console;

namespace Days.Programs
{

    public class HowToInherit : IProgram
    {
        public void Run()
        {
            var inputs = ReadLine().Split();
            var numberOfScores = int.Parse(ReadLine().Trim());
            var scores = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            var student = new Student(inputs[0], inputs[1], int.Parse(inputs[2]), scores);
            student.PrintPerson();
            WriteLine( $"Grade: {student.Calculate()} \n");
        }
    }
}
