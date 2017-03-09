using Days.CoreLibrary;
using static System.Console;

namespace Days.Programs
{
    public class Person : IProgram
    {
        private int age;

        public Person() { }

        public Person(int initialAge)
        {
            if(initialAge < 0)
            {
                WriteLine($"Age is not valid, setting age to 0.");
                age = 0;
            }
            else
            {
                age = initialAge;
            }
        }

        private void YearPasses()
        {
            age++;
        }

        private void AmIOld()
        {
            var output = (age < 13) ? "You are young." : (((age >= 13) && (age < 18)) ? "You are a teenager." : "You are old.");
            WriteLine($"{output}");
        }

        public void Run()
        {
            int numberOfTimes = int.Parse(ReadLine().Trim());
            for (int i = 0; i < numberOfTimes; i++)
            {
                int age = int.Parse(ReadLine().Trim());
                Person p = new Person(age);
                p.AmIOld();
                for (int j = 0; j < 3; j++)
                {
                    p.YearPasses();
                }
                p.AmIOld();
                WriteLine();
            }
        }
    }
}
