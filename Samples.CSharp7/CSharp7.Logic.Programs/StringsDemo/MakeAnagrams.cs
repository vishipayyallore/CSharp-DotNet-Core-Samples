using System;
using System.Diagnostics;

namespace CSharp7.Logic.Programs.StringsDemo
{
    public class MakeAnagrams
    {

        public int Execute(string firstData, string secondData)
        {
            int[] charcterCount = new int[26];
            var tobeRemoved = 0;
            Stopwatch stopwatch = Stopwatch.StartNew();

            foreach (var current in firstData)
            {
                charcterCount[current - 'a']++;
            }

            foreach (var current in secondData)
            {
                charcterCount[current - 'a']--;
            }

            foreach(var current in charcterCount)
            {
                tobeRemoved += Math.Abs(current);
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);

            return tobeRemoved;
        }

    }

}
