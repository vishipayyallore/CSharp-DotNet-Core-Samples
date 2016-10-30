using System.Linq;
using static System.Console;

namespace ArraysNStrings.Lib
{
    public class Welcome
    {
        #region
        public static void Run()
        {
            var numberOfElements = int.Parse(ReadLine().Trim());
            var firstArray = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            var secondArray = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            for (var iCtr = 0; iCtr < numberOfElements; iCtr++)
            {
                Write($"{firstArray[iCtr] + secondArray[iCtr]} ");
            }
        }
        #endregion
    }
}
