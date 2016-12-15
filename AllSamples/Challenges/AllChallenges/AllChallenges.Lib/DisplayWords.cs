using System.Text;
using static System.Console;

namespace AllChallenges.Lib
{
    public class DisplayWords
    {
        public static void Run()
        {
            var inputData = ReadLine().Trim();
            foreach (var currentByte in Encoding.ASCII.GetBytes(inputData))
            {
                if (currentByte >= 65 && currentByte <= 90)
                {
                    WriteLine();
                }
                Write((char)currentByte);
            }
        }
    }
}
