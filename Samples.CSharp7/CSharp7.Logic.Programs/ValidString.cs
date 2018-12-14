namespace CSharp7.Logic.Programs
{
    public static class ValidString
    {

        // Need to change the logic to have array instead of dictionary.
        static string isValid(string inputData)
        {
            int[] charcterCount = new int[26];
            var characterRemoved = 0;

            foreach (var current in inputData)
            {
                charcterCount[current - 'a']++;
            }

            // charcterCount.so

            foreach (var current in charcterCount)
            {
                if (current % 2 == 1)
                {
                    characterRemoved++;
                    if (characterRemoved >= 2)
                    {
                        break;
                    }
                }
            }

            // If the Character Count contains only 1 alphabet series it should return "YES"
            return (characterRemoved == 2) ? "NO" : "YES";

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