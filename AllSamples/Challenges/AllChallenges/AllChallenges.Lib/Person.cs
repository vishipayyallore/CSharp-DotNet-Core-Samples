using static System.Console;

namespace AllChallenges.Lib
{

    public class Person
    {
        public int Age;

        public Person(int initialAge)
        {
            if (initialAge >= 0)
            {
                Age = initialAge;
            }
            else
            {
                Age = 0;
                WriteLine($"Age is not valid, setting age to 0.");
            }
        }

        public void AmIOld()
        {
            string output;

            if (Age < 13)
            {
                output = "You are young.";
            }
            else if (Age >= 13 && Age < 18)
            {
                output = "You are a teenager.";
            }
            else
            {
                output = "You are old.";
            }
            WriteLine($"{output}");
        }

        public void YearPasses()
        {
            Age++;
        }
    }
}
