using System;
using System.Linq;

namespace CSharp7.Logic.Programs
{
    public static class ValidString
    {

        // Need to change the logic to have array instead of dictionary.
        public static string IsValid(string inputData)
        {
            var returnNo = "NO";
            var returnYes = "YES";

            if (string.IsNullOrWhiteSpace(inputData) || inputData.Length <= 3)
            {
                return returnNo;
            }

            int[] charcterCount = new int[26];
            var characterRemoved = 0;

            foreach (var current in inputData)
            {
                charcterCount[current - 'a']++;
            }

            Array.Sort(charcterCount);

            var minimum = charcterCount.Min(element => element != 0);
            var maximum = charcterCount.Max(element => element != 0);

            if (minimum == maximum)
            {
                return returnYes;
            }
            else
            {
                // remove one letter at higher frequency or the lower frequency 
                if (((maximum - minimum == 1) && (maximum > letters[24])) ||
                    (minimum == 1) && (letters[i + 1] == maximum))
                    return returnYes;
            }
            return returnNo;

        }

    }

}

//static String isValid(String s)
//{
//    final String GOOD = "YES";
//    final String BAD = "NO";

//    if (s.isEmpty()) return BAD;
//    if (s.length() <= 3) return GOOD;

//    int[] letters = new int[26];
//    for (int i = 0; i < s.length(); i++)
//    {
//        letters[s.charAt(i) - 'a']++;
//    }
//    Arrays.sort(letters);
//    int i = 0;
//    while (letters[i] == 0)
//    {
//        i++;
//    }
//    //System.out.println(Arrays.toString(letters));
//    int min = letters[i];   //the smallest frequency of some letter
//    int max = letters[25]; // the largest frequency of some letter
//    String ret = BAD;
//    if (min == max) ret = GOOD;
//    else
//    {
//        // remove one letter at higher frequency or the lower frequency 
//        if (((max - min == 1) && (max > letters[24])) ||
//            (min == 1) && (letters[i + 1] == max))
//            ret = GOOD;
//    }
//    return ret;
//}