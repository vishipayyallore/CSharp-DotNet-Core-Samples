using System;

namespace CSharp7.Logic.Programs.StringsDemo
{
    public class MakeAnagrams
    {

        private int[] charcterCount = new int[26];

        //private void GetRemoveCount(string firstData, string secondData)
        //{
        //    var count = 0;
        //    foreach(var current in firstData)
        //    {
        //        charcterCount[current - 'a']++;
        //    }

        //    return count;
        //}

        public int Execute(string firstData, string secondData)
        {
            var tobeRemoved = 0;
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

            return tobeRemoved;
        }

    }

}
