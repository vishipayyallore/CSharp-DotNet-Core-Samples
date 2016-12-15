using static System.Console;

namespace AllChallenges.Lib
{
    public class SherlockAndTheBeast
    {
        public static void Run()
        {
            var repeat = int.Parse(ReadLine());
            while (repeat > 0)
            {
                var numberValue = int.Parse(ReadLine());
                var fives = numberValue;
                while (fives % 3 != 0)
                {
                    fives -= 5;
                }
                WriteLine(fives < 0 ? $"-1" : $"{new string('5', fives)}{new string('3', (numberValue - fives))}");
                repeat--;
            }
        }
    }
}
