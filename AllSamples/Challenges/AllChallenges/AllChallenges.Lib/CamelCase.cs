using System.Linq;
using System.Text;
using static System.Console;

namespace AllChallenges.Lib
{
    public class CamelCase
    {

        public static void Run()
        {
            var inputData = ReadLine().Trim();
            Write(inputData.ToCharArray().Where(currentChar => currentChar >= 65 && currentChar <= 90).Count() + 1);
        }

        public static void Run1()
        {
            var inputData = ReadLine().Trim();
            Write(1 + Encoding.ASCII.GetBytes(inputData).Count(currentByte => currentByte >= 65 && currentByte <= 90));
        }
    }
}
