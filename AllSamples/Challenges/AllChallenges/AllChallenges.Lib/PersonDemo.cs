using static System.Console;

namespace AllChallenges.Lib
{

    public class PersonDemo
    {
        public static void Run()
        {
            var T = int.Parse(ReadLine().Trim());
            for (var i = 0; i < T; i++)
            {
                var age = int.Parse(ReadLine().Trim());
                var p = new Person(age);
                p.AmIOld();
                for (var j = 0; j < 3; j++)
                {
                    p.YearPasses();
                }
                p.AmIOld();
            }
        }
    }
}
