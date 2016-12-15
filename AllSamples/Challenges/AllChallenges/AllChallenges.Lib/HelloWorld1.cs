using static System.Console;

namespace AllChallenges.Lib
{
    public class HelloWorld1
    {
        public static void Run()
        {
            var number = int.Parse(ReadLine());
            var output = "Weird";
            if (number % 2 == 0)
            {
                if ((number >= 2 && number <= 5) || (number > 20))
                {
                    output = "Not Weird";
                }
            }
            WriteLine(output);
        }
    }
}
