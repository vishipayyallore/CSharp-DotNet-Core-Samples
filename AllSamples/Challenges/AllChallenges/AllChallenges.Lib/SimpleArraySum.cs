using System;
using System.Linq;
using static System.Console;

namespace AllChallenges.Lib
{
    public class SimpleArraySum
    {
        public static void Run()
        {
            //For Long
            var number = Convert.ToInt32(ReadLine());
            var arrayValues2 = ReadLine().Split(' ').Select(long.Parse).ToArray();
            WriteLine($"{arrayValues2.Sum()}");

            //For Int
            //var n = Convert.ToInt32(ReadLine());
            //var arrayValues1 = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            //WriteLine($"{arrayValues1.Sum()}");
        }
    }
}
