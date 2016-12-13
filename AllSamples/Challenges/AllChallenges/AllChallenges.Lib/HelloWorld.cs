using static System.Console;

namespace AllChallenges.Lib
{
    public class HelloWorld
    {
        public static void Run()
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            var value1 = int.Parse(ReadLine());
            var value2 = double.Parse(ReadLine());
            var value3 = ReadLine();

            WriteLine($"{i + value1}");
            WriteLine($"{string.Format("{0:0.0}", (d + value2))}");
            WriteLine($"{s}{value3}");
        }
    }
}
